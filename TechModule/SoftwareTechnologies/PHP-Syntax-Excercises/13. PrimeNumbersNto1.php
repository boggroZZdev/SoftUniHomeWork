<form>
    <input type="text" name="num"/>
    <input type="submit" value="Get Primes"/>
</form>
<?php
if  (isset($_GET['num'])){
    $num = intval($_GET['num']);
    for ($a = $num; $a >= 2; $a--){
        if (isPrime($a)){
            echo "$a ";
        }
    }


}

function isPrime($number){
    if ($number<=1){
        return false;
    }
    for ($i = 2; $i*$i<=$number; $i++){
        if ($number%$i==0){
            return false;
        }
    }
    return true;
}