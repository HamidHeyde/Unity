using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    public GameObject cube;
    private float speed = 1.1f;
    private float x,y;
    private float sx,sy,sz;

    public void get_scale()
    {
        sx = cube.transform.localScale.x;
        sy = cube.transform.localScale.y;
        sz = cube.transform.localScale.z;

    }

    public void set_scale()
    {
        cube.transform.localScale = new Vector3(sx, sy, sz);
    }

    public void get_position()
    {
        y = cube.transform.position.y;
        x = cube.transform.position.x;
    }

    public void set_position()
    {
        cube.transform.position = new Vector3(x, y, 0);
    }

    public void move_up()
    {
        get_position();
        y += speed;
        set_position();
    }

    public void move_down()
    {
        get_position();
        y -= speed;
        set_position();
    }

    public void move_left()
    {
        get_position();
        x -= speed;
        set_position();
    }

    public void move_right()
    {
        get_position();
        x += speed;
        set_position();
    }

    public void Zoom_In()
    {
        get_scale();

        sx *= speed;
        sy *= speed;
        sz *= speed;

        set_scale();
    }

    public void Zoom_Out()
    {
        get_scale();

        sx /= speed;
        sy /= speed;
        sz /= speed;

        set_scale();
    }
}
