function storingObjects(arr) {

    let array = new Array();
    for (let i = 0; i<arr.length; i++){
        let args = arr[i].split(' -> ');
        let name = args[0];
        let age = args[1];
        let grade = args[2];

        array.push({Name: name,
            Age:age,
            Grade:grade})
    }
    for (let student of array){
        for(let key of Object.keys(student)){
            console.log(`${key}: ${student[key]}`)
        }
    }
}