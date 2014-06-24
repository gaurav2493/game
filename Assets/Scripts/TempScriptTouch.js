#pragma strict


function Update ()
{
    if ( Input.GetMouseButtonDown(0))
    {
    	
        var hit : RaycastHit;
        var ray : Ray = Camera.main.ScreenPointToRay (Input.mousePosition);
 
        if (Physics.Raycast (ray, hit, 1000.0))
        {  
            Debug.Log("sdgdfhk");
        }
    }
}