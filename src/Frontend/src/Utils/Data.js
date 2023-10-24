import Axios, { Api_Weather } from "./Fetch/Axios";


class Data {
    async GetWeather(){
        var array = Axios.get(Api_Weather)
        .then(response =>{
            return response.data
        })
        .catch(error =>{
            
        })
        return array;
    }
}

export default new Data()