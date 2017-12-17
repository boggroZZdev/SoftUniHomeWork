<form>
    N: <input type="text" name="num"/>
    <input type="submit"/>
</form>
<?php
if (isset($_GET['num'])){
    $number = intval($_GET['num']);
    $sum = 1;
    for ($a = 2; $a <= $number; $a++){
        $sum*=$a;
    }
    echo $sum;
}
