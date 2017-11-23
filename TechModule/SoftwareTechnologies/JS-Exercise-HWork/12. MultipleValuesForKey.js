function multipleValuesKey(arr) {
    let obj = {};
    let testNumber = arr[arr.length-1];
    for (let i = 0; i<arr.length-1; i++){
        let args = arr[i].split(' ');
        let key = args[0];
        obj[key] = args[1];
        if (testNumber===key){
            console.log(obj[key]);
        }

    }



    if (obj.hasOwnProperty(testNumber)){

    }
    else{
        console.log('None')
    }
}