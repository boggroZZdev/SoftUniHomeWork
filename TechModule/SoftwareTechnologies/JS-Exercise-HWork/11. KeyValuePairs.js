function keyValuePair(arr) {
    let obj = {};
    for (let i = 0; i<arr.length-1; i++){
        let args = arr[i].split(' ');
        let key = args[0];
        let value = args[1];
        obj[key] = value;
    }

    if (arr[arr.length-1] in obj){
        console.log(obj[arr[arr.length-1]])
    }
    else{
        console.log("None")
    }

}