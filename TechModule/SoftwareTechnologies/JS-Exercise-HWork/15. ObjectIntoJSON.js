function objectToJSON(arr) {
    let obj = {};
    for(let pair of arr){
        let args = pair.split(" -> ");
        let key = args[0];
        let value = args[1];
        if (!isNaN(value)){
            value = parseFloat(value);
        }
        obj[key] = value;
    }

    let json = JSON.stringify(obj);
    console.log(json)

}