namespace Gioco;

public class Personaggio_Class
{
    public string nome;
    public int hp= 0;
    public int HpMax= 0;
    public int HpScudo= 100;
    public int HpScudoMax= 100;
    public int agilita=0;
    public int intelligenza=0;
    public int forza=0;
            
    public void Guarire(int pozione)
    {
        if (hp < HpMax)
        {

            hp += pozione;
            if (hp > HpMax)
            {
                hp = HpMax;
            }
        }
    }

    public void ScudoRepair(int repair_amout)
    {
        if (HpScudo < HpScudoMax)
        {

            HpScudo += repair_amout;
            if (HpScudo > HpScudoMax)
            {
                HpScudo = HpScudoMax;
            }
        }
    }

    public override string ToString()
    {
        return $"Nome: {nome}, HP: {hp}/{HpMax}, Scudo: {HpScudo}/{HpScudoMax}, Agilità: {agilita}, Intelligenza: {intelligenza}, Forza: {forza}";
    }
}

public class Ladro : Personaggio_Class

{
    public Ladro()
    {


        hp = 60;
        HpMax = 60;
        agilita = 90;
        intelligenza = 90;
        forza = 70;

    }
}

public class Mago : Personaggio_Class
    {
        public Mago()
        {

            hp = 70;
            HpMax = 70;
            agilita = 60;
            intelligenza = 80;
            forza = 60;
        }
    }

public class Guerriero : Personaggio_Class
{
    public Guerriero()
    {
        hp = 150;
        HpMax = 150;
        agilita = 50;
        intelligenza = 40;
        forza = 90;

    }
}

