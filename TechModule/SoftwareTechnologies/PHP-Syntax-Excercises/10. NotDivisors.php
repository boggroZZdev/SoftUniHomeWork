<form>
    N: <input type="text" name="num"/>
    <input type="submit"/>
</form>
<?php
if (isset($_GET['num'])){
    $number = intval($_GET['num']);
    for ($a = $number; $a >= 1; $a--){
        if ($number%$a != 0){
            echo "$a ";
        }
    }
}
