<ul>
    <?php
    for ($a = 1; $a <= 20; $a++){
        if ($a % 2 == 0){
            $color = 'green';
        }else{
            $color = 'blue';
        }
        echo "\t<li><span style='color:$color'>$a</span></li>\n";
    }
    ?>
</ul>