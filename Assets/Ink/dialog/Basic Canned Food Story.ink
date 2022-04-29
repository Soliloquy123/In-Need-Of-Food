-> main

=== main ===
Give them food?
    + [Yes]
        -> given("1 Canned Food") 
    + [No]
        -> given("0 Canned Food") 
        
    === given(food) ===
    you gave {food}
    -> END