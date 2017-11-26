using System.Collections.Generic;

public enum GameYearEnum {
    WW1,
    WW2Early,
    WW2Middle,
    WW2Late,
}

public class GameYear {
    public static List<string> GetVehicleListFromYear(GameYearEnum currentYearEnum){
        List<string> WW1VehicleList = new List<string>() {
            "A7V_SturmpanzerWagen"
        };

        List<string> WW2EarlyVehicleList = new List<string>(){
            "T-26"
        };

        List<string> WW2MiddleVehicleList = new List<string>(){
            "KV2"
        };

        List<string> WW2LateVehicleList = new List<string>() {
            "T-54","T-44","T-34-3","T-62A","Bat_Chatillon155_58"
        };

        switch(currentYearEnum){
            case GameYearEnum.WW1:
                return WW1VehicleList;
            case GameYearEnum.WW2Early:
                return WW2EarlyVehicleList;
            case GameYearEnum.WW2Middle:
                return WW2MiddleVehicleList;
            case GameYearEnum.WW2Late:
                return WW2LateVehicleList;
            default:
                return null;
        }
    }
}