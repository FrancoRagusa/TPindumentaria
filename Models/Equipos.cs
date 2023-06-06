using System.Collections.Generic;

public static class Equipos{
    public static List<string>ListaEquipos {get; private set;} = new List<string>(){
        "river", "boca", "racing", "san lorenzo", "independiente", "velez", "gimnasia", "argentinos junior", "estudiantes", "huracan"
    };
    public static List<string>ListaMedias {get; private set;} = new List<string>(){
        "mediariv.jpg", "mediaboc.jpg", "mediarac.jpg", "mediasan.jpg", "mediaind.jpg", "mediavel.jpg", "mediagim.jpg", "mediaarg.jpg", "mediaest.jpg", "mediahur.jpg"
    };
    public static List<string>ListaPantalones {get; private set;} = new List<string>(){
        "pantriv.jpg", "pantboc.jpg", "pantrac.jpg", "pantsan.jpg", "pantind.jpg", "pantvel.jpg", "pantgim.jpg", "pantarg.jpg", "pantest.jpg", "panthur.jpg"
    };
    public static List<string>ListaRemeras {get; private set;} = new List<string>(){
        "remriv.jpg", "remboc.jpg", "remrac.jpg", "remsan.jpg", "remind.jpg", "remvel.jpg", "remgim.jpg", "remarg.jpg", "remest.jpg", "remhur.jpg"
    };
  
    public static Dictionary<string, Indumentaria>EquiposIndumentaria {get; private set;} = new Dictionary<string, Indumentaria>();

    public static bool IngresarIndumentaria(string EquipoSeleccionado, Indumentaria item){
        bool k = false;
        if(!EquiposIndumentaria.ContainsKey(EquipoSeleccionado)){
            EquiposIndumentaria.Add(EquipoSeleccionado, item);
            k = true;
        }
        return k;
    }
}