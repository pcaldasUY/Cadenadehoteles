﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hoteles_ListadoHoteles : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        gdvListadoHoteles.DataSource = LogicaHotel.Listado();
        gdvListadoHoteles.DataBind();
    }
}