function productValue(nums) {
    let num1 = Number(nums[0]);
    let num2 = Number(nums[1]);
    let num3 = Number(nums[2]);
    if (num1===0||num2===0||num3===0){
        return console.log("Positive")
    }
    else{
        let counter = 0;
        for (let i = 0; i < 3; i++){
            if (nums[i]<0){
                counter++;
            }
        }
        if(counter%2===0){
            return console.log("Positive")
        }
        else{
            return console.log("Negative")
        }
    }
}