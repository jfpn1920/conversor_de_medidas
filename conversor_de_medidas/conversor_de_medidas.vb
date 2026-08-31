Imports System
Module conversor_de_medidas
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim categorias(9) As String
        Dim valores(9) As Double
        Dim unidadesOrigen(9) As String
        Dim unidadesDestino(9) As String
        Dim resultados(9) As Double
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '-----------------------------------------'
        '--|menu_principal_conversor_de_medidas|--'
        '-----------------------------------------'
        Do
            Console.WriteLine("menu principal conversor de medidas")
            Console.WriteLine("1) Registrar conversion")
            Console.WriteLine("2) Editar conversion")
            Console.WriteLine("3) Listar conversiones")
            Console.WriteLine("4) Buscar conversion")
            Console.WriteLine("5) Eliminar conversion")
            Console.WriteLine("6) Mostrar resumen")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '--------------------------'
                '--|registrar_conversion|--'
                '--------------------------'
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas conversiones.")
                    Else
                        ids(cantidad) = cantidad + 1
                        Console.WriteLine("Seleccione la categoria:")
                        Console.WriteLine("1) Longitud")
                        Console.WriteLine("2) Peso")
                        Console.WriteLine("3) Temperatura")
                        Console.Write("Seleccione una opcion: ")
                        Dim tipo As Integer = Convert.ToInt32(Console.ReadLine())
                        If tipo = 1 Then
                            categorias(cantidad) = "Longitud"
                            Console.WriteLine("Unidades disponibles:")
                            Console.WriteLine("1) Metros")
                            Console.WriteLine("2) Kilometros")
                            Console.WriteLine("3) Centimetros")
                            Console.WriteLine("4) Milimetros")
                            Console.Write("Seleccione unidad de origen: ")
                            Dim origen As Integer = Convert.ToInt32(Console.ReadLine())
                            Console.Write("Seleccione unidad de destino: ")
                            Dim destino As Integer = Convert.ToInt32(Console.ReadLine())
                            unidadesOrigen(cantidad) = ObtenerUnidadLongitud(origen)
                            unidadesDestino(cantidad) = ObtenerUnidadLongitud(destino)
                            Console.Write("Ingrese el valor: ")
                            valores(cantidad) = Convert.ToDouble(Console.ReadLine())
                            resultados(cantidad) = ConvertirLongitud(
                                valores(cantidad),
                                unidadesOrigen(cantidad),
                                unidadesDestino(cantidad)
                            )
                        ElseIf tipo = 2 Then
                            categorias(cantidad) = "Peso"
                            Console.WriteLine("Unidades disponibles:")
                            Console.WriteLine("1) Kilogramos")
                            Console.WriteLine("2) Gramos")
                            Console.WriteLine("3) Libras")
                            Console.Write("Seleccione unidad de origen: ")
                            Dim origen As Integer = Convert.ToInt32(Console.ReadLine())
                            Console.Write("Seleccione unidad de destino: ")
                            Dim destino As Integer = Convert.ToInt32(Console.ReadLine())
                            unidadesOrigen(cantidad) = ObtenerUnidadPeso(origen)
                            unidadesDestino(cantidad) = ObtenerUnidadPeso(destino)
                            Console.Write("Ingrese el valor: ")
                            valores(cantidad) = Convert.ToDouble(Console.ReadLine())
                            resultados(cantidad) = ConvertirPeso(
                                valores(cantidad),
                                unidadesOrigen(cantidad),
                                unidadesDestino(cantidad)
                            )
                        ElseIf tipo = 3 Then
                            categorias(cantidad) = "Temperatura"
                            Console.WriteLine("Unidades disponibles:")
                            Console.WriteLine("1) Celsius")
                            Console.WriteLine("2) Fahrenheit")
                            Console.WriteLine("3) Kelvin")
                            Console.Write("Seleccione unidad de origen: ")
                            Dim origen As Integer = Convert.ToInt32(Console.ReadLine())
                            Console.Write("Seleccione unidad de destino: ")
                            Dim destino As Integer = Convert.ToInt32(Console.ReadLine())
                            unidadesOrigen(cantidad) = ObtenerUnidadTemperatura(origen)
                            unidadesDestino(cantidad) = ObtenerUnidadTemperatura(destino)
                            Console.Write("Ingrese el valor: ")
                            valores(cantidad) = Convert.ToDouble(Console.ReadLine())
                            resultados(cantidad) = ConvertirTemperatura(
                                valores(cantidad),
                                unidadesOrigen(cantidad),
                                unidadesDestino(cantidad)
                            )
                        Else
                            Console.WriteLine("Categoria no valida.")
                            ids(cantidad) = 0
                            Continue Do
                        End If
                        cantidad += 1
                        Console.WriteLine("Conversion registrada correctamente.")
                        Console.WriteLine("ID: " & ids(cantidad - 1) & " | Categoria: " & categorias(cantidad - 1) & " | Valor: " & valores(cantidad - 1) & " | Origen: " & unidadesOrigen(cantidad - 1) & " | Destino: " & unidadesDestino(cantidad - 1) & " | Resultado: " & resultados(cantidad - 1))
                    End If
                '-----------------------'
                '--|editar_conversion|--'
                '-----------------------'
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen conversiones registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Categoria: " & categorias(i) & " | Valor: " & valores(i) & " | Origen: " & unidadesOrigen(i) & " | Destino: " & unidadesDestino(i) & " | Resultado: " & resultados(i))
                        Next
                        Console.Write("Ingrese el ID de la conversion a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 And idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.WriteLine("Seleccione la nueva categoria:")
                            Console.WriteLine("1) Longitud")
                            Console.WriteLine("2) Peso")
                            Console.WriteLine("3) Temperatura")
                            Console.Write("Seleccione una opcion: ")
                            Dim tipo As Integer = Convert.ToInt32(Console.ReadLine())
                            If tipo = 1 Then
                                categorias(posicion) = "Longitud"
                                Console.WriteLine("Unidades disponibles:")
                                Console.WriteLine("1) Metros")
                                Console.WriteLine("2) Kilometros")
                                Console.WriteLine("3) Centimetros")
                                Console.WriteLine("4) Milimetros")
                                Console.Write("Seleccione unidad de origen: ")
                                Dim origen As Integer = Convert.ToInt32(Console.ReadLine())
                                Console.Write("Seleccione unidad de destino: ")
                                Dim destino As Integer = Convert.ToInt32(Console.ReadLine())
                                unidadesOrigen(posicion) = ObtenerUnidadLongitud(origen)
                                unidadesDestino(posicion) = ObtenerUnidadLongitud(destino)
                                Console.Write("Ingrese el nuevo valor: ")
                                valores(posicion) = Convert.ToDouble(Console.ReadLine())
                                resultados(posicion) = ConvertirLongitud(
                                    valores(posicion),
                                    unidadesOrigen(posicion),
                                    unidadesDestino(posicion)
                                )
                            ElseIf tipo = 2 Then
                                categorias(posicion) = "Peso"
                                Console.WriteLine("Unidades disponibles:")
                                Console.WriteLine("1) Kilogramos")
                                Console.WriteLine("2) Gramos")
                                Console.WriteLine("3) Libras")
                                Console.Write("Seleccione unidad de origen: ")
                                Dim origen As Integer = Convert.ToInt32(Console.ReadLine())
                                Console.Write("Seleccione unidad de destino: ")
                                Dim destino As Integer = Convert.ToInt32(Console.ReadLine())
                                unidadesOrigen(posicion) = ObtenerUnidadPeso(origen)
                                unidadesDestino(posicion) = ObtenerUnidadPeso(destino)
                                Console.Write("Ingrese el nuevo valor: ")
                                valores(posicion) = Convert.ToDouble(Console.ReadLine())
                                resultados(posicion) = ConvertirPeso(
                                    valores(posicion),
                                    unidadesOrigen(posicion),
                                    unidadesDestino(posicion)
                                )
                            ElseIf tipo = 3 Then
                                categorias(posicion) = "Temperatura"
                                Console.WriteLine("Unidades disponibles:")
                                Console.WriteLine("1) Celsius")
                                Console.WriteLine("2) Fahrenheit")
                                Console.WriteLine("3) Kelvin")
                                Console.Write("Seleccione unidad de origen: ")
                                Dim origen As Integer = Convert.ToInt32(Console.ReadLine())
                                Console.Write("Seleccione unidad de destino: ")
                                Dim destino As Integer = Convert.ToInt32(Console.ReadLine())
                                unidadesOrigen(posicion) = ObtenerUnidadTemperatura(origen)
                                unidadesDestino(posicion) = ObtenerUnidadTemperatura(destino)
                                Console.Write("Ingrese el nuevo valor: ")
                                valores(posicion) = Convert.ToDouble(Console.ReadLine())
                                resultados(posicion) = ConvertirTemperatura(
                                    valores(posicion),
                                    unidadesOrigen(posicion),
                                    unidadesDestino(posicion)
                                )
                            Else
                                Console.WriteLine("Categoria no valida.")
                                Continue Do
                            End If
                            Console.WriteLine("Conversion actualizada correctamente.")
                            Console.WriteLine("ID: " & ids(posicion) & " | Categoria: " & categorias(posicion) & " | Valor: " & valores(posicion) & " | Origen: " & unidadesOrigen(posicion) & " | Destino: " & unidadesDestino(posicion) & " | Resultado: " & resultados(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '-------------------------'
                '--|listar_conversiones|--'
                '-------------------------'
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen conversiones registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Categoria: " & categorias(i) & " | Valor: " & valores(i) & " | Origen: " & unidadesOrigen(i) & " | Destino: " & unidadesDestino(i) & " | Resultado: " & resultados(i))
                        Next
                    End If
                '-----------------------'
                '--|buscar_conversion|--'
                '-----------------------'
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen conversiones registradas.")
                    Else
                        Console.WriteLine("1) Buscar por ID")
                        Console.WriteLine("2) Buscar por categoria")
                        Console.WriteLine("3) Buscar por unidad de origen")
                        Console.WriteLine("4) Buscar por unidad de destino")
                        Console.Write("Seleccione una opcion: ")
                        Dim tipoBusqueda As Integer = Convert.ToInt32(Console.ReadLine())
                        If tipoBusqueda = 1 Then
                            Console.Write("Ingrese el ID de la conversion: ")
                            Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                            If idBuscar >= 1 And idBuscar <= cantidad Then
                                Dim posicion As Integer = idBuscar - 1
                                Console.WriteLine("ID: " & ids(posicion) & " | Categoria: " & categorias(posicion) & " | Valor: " & valores(posicion) & " | Origen: " & unidadesOrigen(posicion) & " | Destino: " & unidadesDestino(posicion) & " | Resultado: " & resultados(posicion))
                            Else
                                Console.WriteLine("ID no encontrada.")
                            End If
                        ElseIf tipoBusqueda = 2 Then
                            Console.Write("Ingrese la categoria: ")
                            Dim categoriaBuscar As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If categorias(i).ToLower() = categoriaBuscar.ToLower() Then
                                    Console.WriteLine("ID: " & ids(i) & " | Categoria: " & categorias(i) & " | Valor: " & valores(i) & " | Origen: " & unidadesOrigen(i) & " | Destino: " & unidadesDestino(i) & " | Resultado: " & resultados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No se encontraron conversiones para esa categoria.")
                            End If
                        ElseIf tipoBusqueda = 3 Then
                            Console.Write("Ingrese la unidad de origen: ")
                            Dim origenBuscar As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If unidadesOrigen(i).ToLower() = origenBuscar.ToLower() Then
                                    Console.WriteLine("ID: " & ids(i) & " | Categoria: " & categorias(i) & " | Valor: " & valores(i) & " | Origen: " & unidadesOrigen(i) & " | Destino: " & unidadesDestino(i) & " | Resultado: " & resultados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No se encontraron conversiones con esa unidad de origen.")
                            End If
                        ElseIf tipoBusqueda = 4 Then
                            Console.Write("Ingrese la unidad de destino: ")
                            Dim destinoBuscar As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If unidadesDestino(i).ToLower() = destinoBuscar.ToLower() Then
                                    Console.WriteLine("ID: " & ids(i) & " | Categoria: " & categorias(i) & " | Valor: " & valores(i) & " | Origen: " & unidadesOrigen(i) & " | Destino: " & unidadesDestino(i) & " | Resultado: " & resultados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No se encontraron conversiones con esa unidad de destino.")
                            End If
                        Else
                            Console.WriteLine("Opcion no valida.")
                        End If
                    End If
                '-------------------------'
                '--|eliminar_conversion|--'
                '-------------------------'
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen conversiones registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Categoria: " & categorias(i) & " | Valor: " & valores(i) & " | Origen: " & unidadesOrigen(i) & " | Destino: " & unidadesDestino(i) & " | Resultado: " & resultados(i))
                        Next
                        Console.Write("Ingrese el ID de la conversion a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 And idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                categorias(i) = categorias(i + 1)
                                valores(i) = valores(i + 1)
                                unidadesOrigen(i) = unidadesOrigen(i + 1)
                                unidadesDestino(i) = unidadesDestino(i + 1)
                                resultados(i) = resultados(i + 1)
                            Next
                            cantidad -= 1
                            ids(cantidad) = 0
                            categorias(cantidad) = ""
                            valores(cantidad) = 0
                            unidadesOrigen(cantidad) = ""
                            unidadesDestino(cantidad) = ""
                            resultados(cantidad) = 0
                            For i As Integer = 0 To cantidad - 1
                                ids(i) = i + 1
                            Next
                            Console.WriteLine("Conversion eliminada correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------'
                '--|mostrar_resumen|--'
                '---------------------'
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen conversiones registradas.")
                    Else
                        Dim conversionesLongitud As Integer = 0
                        Dim conversionesPeso As Integer = 0
                        Dim conversionesTemperatura As Integer = 0
                        Dim resultadoMayor As Double = resultados(0)
                        Dim resultadoMenor As Double = resultados(0)
                        Dim conversionMayor As String =
                            unidadesOrigen(0) & " a " & unidadesDestino(0)
                        Dim conversionMenor As String =
                            unidadesOrigen(0) & " a " & unidadesDestino(0)
                        For i As Integer = 0 To cantidad - 1
                            If categorias(i) = "Longitud" Then
                                conversionesLongitud += 1
                            ElseIf categorias(i) = "Peso" Then
                                conversionesPeso += 1
                            ElseIf categorias(i) = "Temperatura" Then
                                conversionesTemperatura += 1
                            End If
                            If resultados(i) > resultadoMayor Then
                                resultadoMayor = resultados(i)
                                conversionMayor =
                                    unidadesOrigen(i) & " a " & unidadesDestino(i)
                            End If
                            If resultados(i) < resultadoMenor Then
                                resultadoMenor = resultados(i)
                                conversionMenor =
                                    unidadesOrigen(i) & " a " & unidadesDestino(i)
                            End If
                        Next
                        Console.WriteLine("Conversiones: " & cantidad & " | Longitud: " & conversionesLongitud & " | Peso: " & conversionesPeso & " | Temperatura: " & conversionesTemperatura & " | Mayor resultado: " & resultadoMayor & " (" & conversionMayor & ")" & " | Menor resultado: " & resultadoMenor & " (" & conversionMenor & ")")
                    End If
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 7
                    Console.WriteLine("Gracias por utilizar Conversor de Medidas.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 7
    End Sub
    '-----------------------------'
    '--|obtener_unidad_longitud|--'
    '-----------------------------'
    Function ObtenerUnidadLongitud(opcion As Integer) As String
        Select Case opcion
            Case 1
                Return "Metros"
            Case 2
                Return "Kilometros"
            Case 3
                Return "Centimetros"
            Case 4
                Return "Milimetros"
            Case Else
                Return "No valida"
        End Select
    End Function
    '-------------------------'
    '--|obtener_unidad_peso|--'
    '-------------------------'
    Function ObtenerUnidadPeso(opcion As Integer) As String
        Select Case opcion
            Case 1
                Return "Kilogramos"
            Case 2
                Return "Gramos"
            Case 3
                Return "Libras"
            Case Else
                Return "No valida"
        End Select
    End Function
    '--------------------------------'
    '--|obtener_unidad_temperatura|--'
    '--------------------------------'
    Function ObtenerUnidadTemperatura(opcion As Integer) As String
        Select Case opcion
            Case 1
                Return "Celsius"
            Case 2
                Return "Fahrenheit"
            Case 3
                Return "Kelvin"
            Case Else
                Return "No valida"
        End Select
    End Function
    '------------------------'
    '--|convertir_longitud|--'
    '------------------------'
    Function ConvertirLongitud(valor As Double, origen As String, destino As String) As Double
        Dim metros As Double
        Select Case origen
            Case "Metros"
                metros = valor
            Case "Kilometros"
                metros = valor * 1000
            Case "Centimetros"
                metros = valor / 100
            Case "Milimetros"
                metros = valor / 1000
        End Select
        Select Case destino
            Case "Metros"
                Return metros
            Case "Kilometros"
                Return metros / 1000
            Case "Centimetros"
                Return metros * 100
            Case "Milimetros"
                Return metros * 1000
            Case Else
                Return 0
        End Select
    End Function
    '--------------------'
    '--|convertir_peso|--'
    '--------------------'
    Function ConvertirPeso(valor As Double, origen As String, destino As String) As Double
        Dim kilogramos As Double
        Select Case origen
            Case "Kilogramos"
                kilogramos = valor
            Case "Gramos"
                kilogramos = valor / 1000
            Case "Libras"
                kilogramos = valor * 0.453592
        End Select
        Select Case destino
            Case "Kilogramos"
                Return kilogramos
            Case "Gramos"
                Return kilogramos * 1000
            Case "Libras"
                Return kilogramos / 0.453592
            Case Else
                Return 0
        End Select
    End Function
    '---------------------------'
    '--|convertir_temperatura|--'
    '---------------------------'
    Function ConvertirTemperatura(valor As Double, origen As String, destino As String) As Double
        Dim celsius As Double
        Select Case origen
            Case "Celsius"
                celsius = valor
            Case "Fahrenheit"
                celsius = (valor - 32) * 5 / 9
            Case "Kelvin"
                celsius = valor - 273.15
        End Select
        Select Case destino
            Case "Celsius"
                Return celsius
            Case "Fahrenheit"
                Return (celsius * 9 / 5) + 32
            Case "Kelvin"
                Return celsius + 273.15
            Case Else
                Return 0
        End Select
    End Function
End Module