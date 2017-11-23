function workOnArray(args){
    let arr = [];
    for (let i = 0; i < args.length; i++){
        let currArgs = args[i].split(' ');
        let command = currArgs[0];
        let index = currArgs[1];
        if (command==='add'){
            arr.push(index);
        }
        else if (command === 'remove'){
            arr.splice(index,1);
        }
    }

    for (let i = 0; i<arr.length; i++){
        console.log(arr[i]);
    }
}