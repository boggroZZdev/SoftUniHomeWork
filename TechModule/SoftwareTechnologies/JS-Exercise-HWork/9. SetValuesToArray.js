function setValues(n) {
    let count = Number(n[0]);
    let arr = [];
    for (let i = 1; i<n.length;i++){
        let current = n[i].split(' - ');
        let index = current[0];
        let number = current[1];
        arr[index] = number;
    }
    for (let i = 0; i<count; i++){
        if (arr[i]===undefined){
            console.log(0);
        }
        else{
            console.log(arr[i]);
        }
    }
}