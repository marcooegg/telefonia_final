Imports Telefonia_Entidades
Module Module1
    Enum opcionesMenu
        Salir
        AltaCliente
        AltaLinea
        AsignarLinea
        ListarLineas
    End Enum
    Sub Main()
        Dim padronClientes As New List(Of Cliente)
        Dim listaLineas As New List(Of Linea)
        Dim opcion As Byte
        Dim cliente1 As New Persona()
        Dim ocupa As New Cliente
        padronClientes.Add(ocupa)
        cliente1.nombre = "fulano"
        cliente1.documento = "11111111"
        padronClientes.Add(cliente1)
        cliente1.Id = padronClientes.LastIndexOf(cliente1)
        Console.WriteLine(cliente1.Id)
        Do
            Console.WriteLine("Que desea hacer?")
            Console.WriteLine(opcionesMenu.AltaCliente & "Alta de Cliente")
            Console.WriteLine(opcionesMenu.AltaLinea & "Alta de Linea")
            Console.WriteLine(opcionesMenu.AsignarLinea & "Asignar una linea")
            Console.WriteLine(opcionesMenu.ListarLineas & "Listar lineas por cliente")
            Console.WriteLine(opcionesMenu.Salir & "Salir")
            opcion = Console.ReadLine()
            Select Case opcion
                Case opcionesMenu.AltaCliente
                    altaCliente(padronClientes)
                Case opcionesMenu.AltaLinea
                    altaLinea(listaLineas)
                Case opcionesMenu.AsignarLinea
                    asignarLineaCliente(padronClientes, listaLineas)
                Case opcionesMenu.ListarLineas
                    mostrarLineas(padronClientes)
            End Select
        Loop Until opcion = opcionesMenu.Salir

    End Sub

    Sub altaLinea(ByRef listaLineas As List(Of Linea))
        Try
            Dim linea As New Linea()
            Console.WriteLine("ingrese codigo de area")
            linea.CodigoArea = Console.ReadLine()
            Console.WriteLine("ingrese numero de telefono")
            linea.Numero = Console.ReadLine()
            listaLineas.Add(linea)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try
    End Sub
    Sub altaCliente(ByRef padronClientes As List(Of Cliente))
        Try
            Dim client As New Cliente()
            padronClientes.Add(client)
            client.Id = padronClientes.LastIndexOf(client)
            Console.WriteLine("nuevo cliente agregado, su id es " & client.Id)
        Catch ex As Exception

        End Try
    End Sub
    Sub asignarLineaCliente(ByRef padronClientes As List(Of Cliente), listaLineas As List(Of Linea))
        Try
            Console.WriteLine("Ingrese id del cliente")
            Dim idCliente As UInteger = Console.ReadLine()
            Console.WriteLine("ingrese nro de telefono de la linea")
            Dim numero As UInteger = Console.ReadLine()
            For Each line As Linea In listaLineas
                If line.Numero = numero Then
                    padronClientes(idCliente).addLinea(line)
                End If
            Next
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
            Console.Clear()
        End Try
    End Sub
    Sub mostrarLineas(padronClientes As List(Of Cliente))
        Try
            Console.WriteLine("ingrese id de cliente")
            Dim id As UInteger = Console.ReadLine()
            For Each line As Linea In padronClientes(id).getAllLineas
                Console.WriteLine("{0}-{1}", line.CodigoArea, line.Numero)
            Next
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.ReadKey()
        End Try
    End Sub
End Module
