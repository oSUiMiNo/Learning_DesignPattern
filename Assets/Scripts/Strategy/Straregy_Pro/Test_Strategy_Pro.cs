using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Strategy_Pro : MonoBehaviour
{
    string name = "";
    int costMP = 1;
    int atk = 1;
    int costTP = 1;    //テクニカルポイントが追加された。特に意味はない。

    Dictionary<MagicType, Magic> magics = new Dictionary<MagicType, Magic>();
    //全魔法クラスを Magic() インターフェイスで抽象化したことによって、
    //同じ辞書に全部収納できるのが大きなポイント。

    //ここで辞書にまとめることだけが目的であれば、object型 として収納することもできた。

    void Start()
    {
        magics.Add(MagicType.fire, new Fire());
        magics.Add(MagicType.shiden, new Shiden());
        magics.Add(MagicType.hellFire, new HellFire());

        Test();
    }

    void Test()
    {
        MagicAttack(MagicType.fire, Common.inst.member1);
        Debug.Log($" {name} {costMP} {atk}");

        MagicAttack(MagicType.shiden, Common.inst.member2);
        Debug.Log($" {name} {costMP} {atk}");
    }

    //しかしそれだとここで型変換用の条件分岐をしてしまうので、インターフェイスにした。
    //↑ これに関しては Test_Interface_Proクラス, Test_Interface_Antiクラス を参照

    //さらに、辞書のキーによってどの魔法か判断してくれるので条件分岐が必要なくなった。
    void MagicAttack(MagicType magicType, Member member)
    {
        Magic usemagic = magics[magicType];
        
        usemagic.SpecifyMember(member);
        name = usemagic.Name();
        costMP = usemagic.CostMP();
        atk = usemagic.Atk();
        costTP = usemagic.CostTP();
    }
    //「地獄の業火」の件のように魔法が追加された際は、
    //魔法のロジックをまとめたクラスを作り、辞書に追加するだけ。
    //なので、あんまりロジックが膨れずに済む。
    
    //「テクニカルポイント」の件のように魔法の仕様が追加された際は、
    //まずインターフェイスに関数を追加する。
    //すると、魔法ロジックに新仕様を追加し忘れた場合にエラーで知らせてくれる。
}
