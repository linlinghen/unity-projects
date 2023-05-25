using UnityEngine;
using UnityEngine.SceneManagement;
public class Bohemyan : MonoBehaviour
{
    public GameObject[] cubes; // Array of cube GameObjects
    
    private void OnMouseDown()
    {
        

        // Check if the clicked cube is the designated cube
        if (gameObject == cubes[3])
        {
              




            // Perform actions specific to the designated cube
            Debug.Log("Clicked on the designated cube!");

            int maxIndex = Mathf.Min(cubes.Length - 1, 3); // Calculate the maximum valid index to avoid going out of bounds

            for (int j = 0; j <= maxIndex; j++)
            {
                ChangeColor(cubes[j]);
            }
        }
        if (gameObject == cubes[5])
        {
            // Perform actions specific to the designated cube
            Debug.Log("Clicked on!");

             // Calculate the maximum valid index to avoid going out of bounds

            for ( int j = 5; j <=6 ; j++)
            {
                ChangeColor(cubes[j]);
            }
        }


        if (gameObject == cubes[4])
        {
            
             Renderer cubeRenderer = cubes[4].GetComponent<Renderer>();
        cubeRenderer.material.color = Color.green;

        Invoke("Menu", 3f);
            
        }
    }
   //Public clas  inginer etc 
   
   //{ public inginer print;
  // public int ok;
   //public void OnMouseDown()
   //{
   //print.ok=1; 
   //}
   //}

     
    private void ChangeColor(GameObject cube)
    {
        Renderer cubeRenderer = cube.GetComponent<Renderer>();
        cubeRenderer.material.color = Color.red;
    }

    public void Menu ()
    {
    SceneManager.LoadScene(1);
    }
}

