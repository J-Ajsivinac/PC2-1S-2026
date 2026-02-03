Imports System

Module Program
    Sub Main(args As String())
        'Console.WriteLine("Hello World!")

        ' ============================================================================
        ' DECLARACIÓN DE VARIABLES PARA PRODUCTOS
        ' ============================================================================
        ' Cada producto tiene: nombre (String), precio base (Double), stock (Integer)
        ' y tres precios diferenciados según el tipo de cliente (Double)

        ' Producto 1: Detergente
        Dim NombreProducto1 As String = "Detergente"
        Dim PrecioBaseProducto1 As Double = 5.0
        Dim StockProducto1 As Integer = 50
        Dim PrecioRegularProducto1 As Double = 5.0
        Dim PrecioMayoristaProducto1 As Double = 4.5
        Dim PrecioPremiumProducto1 As Double = 4.0

        ' Producto 2: Desinfectante
        Dim NombreProducto2 As String = "Desinfectante"
        Dim PrecioBaseProducto2 As Double = 7.0
        Dim StockProducto2 As Integer = 40
        Dim PrecioRegularProducto2 As Double = 7.0
        Dim PrecioMayoristaProducto2 As Double = 6.5
        Dim PrecioPremiumProducto2 As Double = 6.0

        ' Producto 3: Cloro
        Dim NombreProducto3 As String = "Cloro"
        Dim PrecioBaseProducto3 As Double = 3.5
        Dim StockProducto3 As Integer = 60
        Dim PrecioRegularProducto3 As Double = 3.5
        Dim PrecioMayoristaProducto3 As Double = 3.0
        Dim PrecioPremiumProducto3 As Double = 2.5

        ' ============================================================================
        ' DECLARACIÓN DE VARIABLES PARA CLIENTES
        ' ============================================================================
        ' El sistema maneja hasta 3 clientes simultáneamente
        ' Cada cliente tiene: nombre (String), tipo (String), subtotal (Double)
        ' y cantidades compradas de cada producto (Integer)

        ' Cliente 1
        Dim NombreCliente1 As String = ""
        Dim TipoCliente1 As String = ""
        Dim SubtotalCliente1 As Double = 0.0
        Dim CantidadProducto1Cliente1 As Integer = 0
        Dim CantidadProducto2Cliente1 As Integer = 0
        Dim CantidadProducto3Cliente1 As Integer = 0

        ' Cliente 2
        Dim NombreCliente2 As String = ""
        Dim TipoCliente2 As String = ""
        Dim SubtotalCliente2 As Double = 0.0
        Dim CantidadProducto1Cliente2 As Integer = 0
        Dim CantidadProducto2Cliente2 As Integer = 0
        Dim CantidadProducto3Cliente2 As Integer = 0

        ' Cliente 3
        Dim NombreCliente3 As String = ""
        Dim TipoCliente3 As String = ""
        Dim SubtotalCliente3 As Double = 0.0
        Dim CantidadProducto1Cliente3 As Integer = 0
        Dim CantidadProducto2Cliente3 As Integer = 0
        Dim CantidadProducto3Cliente3 As Integer = 0

        ' ============================================================================
        ' VARIABLES DEL SISTEMA Y FECHA
        ' ============================================================================
        ' Date.Now obtiene la fecha y hora actual del sistema operativo
        Dim FechaActual As Date = Date.Now
        'FechaActual.dayof
        ' DayOfWeek es una enumeración que devuelve el día de la semana
        ' Saturday = 6, Sunday = 0 en la enumeración DayOfWeek
        ' OrElse es el operador lógico OR con cortocircuito (si el primero es True, no evalúa el segundo)
        Dim EsFinDeSemana As Boolean = (FechaActual.DayOfWeek = DayOfWeek.Saturday OrElse FechaActual.DayOfWeek = DayOfWeek.Sunday)

        'Console.WriteLine("el valor de EsFinDeSemana es: " & EsFinDeSemana.ToString())

        ' Byte es un tipo de dato numérico pequeño (0-255), ideal para contadores pequeños
        Dim IntentosLogin As Byte = 0

        ' Contraseña fija del sistema para validar acceso
        Dim ContraseñaCorrecta As String = "admin123"

        ' Boolean para controlar si el login fue exitoso
        Dim LoggedIn As Boolean = False

        ' ============================================================================
        ' SISTEMA DE AUTENTICACIÓN (LOGIN)
        ' ============================================================================
        ' Usamos un bucle Do...Loop Until para repetir el proceso hasta que:
        ' - El usuario ingrese la contraseña correcta, O
        ' - Se agoten los 3 intentos permitidos

        Do
            Console.WriteLine("Ingrese la contraseña para acceder al sistema (intentos restantes: " & (3 - IntentosLogin) & "): ")
            ' Console.ReadLine() lee una línea completa de texto ingresada por el usuario
            ' .Trim() elimina espacios en blanco al inicio y final del texto
            ' " admin132 " -> "admin132"
            ' "1" -> string con un solo caracter '1'
            ' Esto evita errores si el usuario accidentalmente presiona espacios
            Dim Input As String = Console.ReadLine().Trim()

            ' Comparamos la entrada con la contraseña correcta
            If Input = ContraseñaCorrecta Then
                LoggedIn = True
                Console.WriteLine("Acceso concedido. Bienvenido al sistema.")
            Else
                IntentosLogin += 1 ' Incrementamos el contador de intentos fallidos intentosLogin = intentosLogin + 1
                Console.WriteLine("Contraseña incorrecta.")

                If IntentosLogin >= 3 Then
                    Console.WriteLine("Se han agotado los intentos. Acceso denegado.")
                    ' Return termina la ejecución del Sub Main, cerrando el programa
                    Return
                End If
            End If
        Loop Until LoggedIn ' Se va a repetir hasta que LoggedIn sea True




        ' Mostramos información del sistema una vez autenticado
        ' .ToString("dd/MM/yyyy") formatea la fecha en formato día/mes/año
        ' vbCrLf es un salto de línea (carriage return + line feed)
        Console.WriteLine(vbCrLf & "Fecha actual: " & FechaActual.ToString("dd/MM/yyyy"))
        Console.WriteLine("Es fin de semana: " & EsFinDeSemana)

        ' ============================================================================
        ' REGISTRO DE CLIENTES
        ' ============================================================================
        ' Contador de clientes registrados exitosamente
        Dim NumClientes As Integer = 0

        ' Boolean para controlar si se continúa registrando clientes
        Dim ContinuarRegistro As Boolean = True

        ' Bucle While: se ejecuta mientras la condición sea verdadera
        ' AndAlso es el operador AND con cortocircuito (si el primero es False, no evalúa el segundo)
        While ContinuarRegistro AndAlso NumClientes < 3 ' 3 es el máximo de clientes permitidos
            NumClientes += 1
            ' vbCrLf es una constante que representa un salto de línea (Carriage Return + Line Feed)
            Console.WriteLine(vbCrLf & "========== REGISTRAR CLIENTE " & NumClientes & " ==========")
            Console.Write("Nombre del cliente (o escriba 'f' para finalizar): ")
            Dim Nombre As String = Console.ReadLine().Trim()

            ' "HOLA" .ToLower() -> "hola"
            ' "hola" .ToUpper() -> "HOLA"
            ' .ToLower() convierte todo el texto a minúsculas
            ' Esto permite comparar sin importar si el usuario escribió F, f, o cualquier combinación
            If Nombre.ToLower() = "f" Then
                ' Si el usuario quiere finalizar, decrementamos el contador
                NumClientes -= 1
                ContinuarRegistro = False
                ' Caso cuando se ingresa un nombre válido
            Else
                ' ========================================================================
                ' VALIDACIÓN DEL TIPO DE CLIENTE
                ' ========================================================================
                ' Solo se aceptan tres tipos: Regular, Mayorista, Premium
                ' Tipo as Integer: 1 = Regular, 2 = Mayorista, 3 = Premium
                Dim Tipo As String = ""

                ' Bucle Do...Loop Until para repetir hasta obtener un tipo válido
                Do
                    Console.Write("Tipo de cliente (Regular, Mayorista, Premium): ")
                    Tipo = Console.ReadLine().Trim()

                    ' <> significa "diferente de" en VB.NET,  equivalente a != en otros lenguajes
                    ' Verificamos que NO sea ninguno de los tipos válidos
                    ' El usuario ingreso un tipo inválido
                    If Tipo <> "Regular" AndAlso Tipo <> "Mayorista" AndAlso Tipo <> "Premium" Then
                        Console.WriteLine("ERROR: Tipo inválido. Debe ser: Regular, Mayorista o Premium")
                    End If
                Loop Until Tipo = "Regular" OrElse Tipo = "Mayorista" OrElse Tipo = "Premium"

                ' ========================================================================
                ' ASIGNACIÓN DE DATOS AL CLIENTE CORRESPONDIENTE
                ' ========================================================================
                ' Select Case evalúa una variable y ejecuta el código del caso que coincida
                ' Es más limpio que múltiples If-ElseIf cuando comparamos la misma variable
                ' va a evaluar NumClientes (1, 2 o 3)
                Select Case NumClientes
                    ' Numero Cliente sea 1, asigna a las variables del Cliente 1
                    ' numClientes = 1
                    Case 1
                        NombreCliente1 = Nombre
                        TipoCliente1 = Tipo
                    ' Numero Cliente sea 2, asigna a las variables del Cliente 2
                    ' numClientes = 2
                    Case 2
                        NombreCliente2 = Nombre
                        TipoCliente2 = Tipo
                    ' Numero Cliente sea 3, asigna a las variables del Cliente 3
                    ' numClientes = 3
                    Case 3
                        NombreCliente3 = Nombre
                        TipoCliente3 = Tipo
                End Select

                ' Variables temporales para el proceso de compra del cliente actual
                Dim Subtotal As Double = 0.0
                Dim NumProductosDiferentes As Integer = 0

                ' Booleanos para rastrear si compró productos específicos (para descuentos)
                Dim ComproDetergente As Boolean = False
                Dim ComproCloro As Boolean = False

                ' ====================================================================
                ' PROCESO DE COMPRA DEL CLIENTE
                ' ====================================================================
                Dim ContinuarCompra As Boolean = True

                ' Bucle principal de compras: se repite hasta que el cliente finalice
                Do
                    ' Mostramos el inventario actual de productos
                    Console.WriteLine(vbCrLf & "========== INVENTARIO ACTUAL ==========")
                    ' .ToString("F2") formatea números con 2 decimales (F = Fixed-point)
                    If Tipo = "Regular" Then
                        ' Mostrar precios para cliente Regular
                        Console.WriteLine("1 - " & NombreProducto1 & ": Q" & PrecioRegularProducto1.ToString("F2") & " (Stock: " & StockProducto1 & ")")
                        Console.WriteLine("2 - " & NombreProducto2 & ": Q" & PrecioRegularProducto2.ToString("F2") & " (Stock: " & StockProducto2 & ")")
                        Console.WriteLine("3 - " & NombreProducto3 & ": Q" & PrecioRegularProducto3.ToString("F2") & " (Stock: " & StockProducto3 & ")")
                    ElseIf Tipo = "Mayorista" Then
                        Console.WriteLine("1 - " & NombreProducto1 & ": Q" & PrecioMayoristaProducto1.ToString("F2") & " (Stock: " & StockProducto1 & ")")
                        Console.WriteLine("2 - " & NombreProducto2 & ": Q" & PrecioMayoristaProducto2.ToString("F2") & " (Stock: " & StockProducto2 & ")")
                        Console.WriteLine("3 - " & NombreProducto3 & ": Q" & PrecioMayoristaProducto3.ToString("F2") & " (Stock: " & StockProducto3 & ")")
                    ElseIf Tipo = "Premium" Then
                        Console.WriteLine("1 - " & NombreProducto1 & ": Q" & PrecioPremiumProducto1.ToString("F2") & " (Stock: " & StockProducto1 & ")")
                        Console.WriteLine("2 - " & NombreProducto2 & ": Q" & PrecioPremiumProducto2.ToString("F2") & " (Stock: " & StockProducto2 & ")")
                        Console.WriteLine("3 - " & NombreProducto3 & ": Q" & PrecioPremiumProducto3.ToString("F2") & " (Stock: " & StockProducto3 & ")")
                    End If

                    Console.WriteLine("========================================")

                    Console.WriteLine(vbCrLf & "Seleccione acción:")
                    Console.WriteLine("1 - Agregar producto al carrito")
                    Console.WriteLine("2 - Finalizar compra")
                    Console.Write("Opción: ")

                    Dim OpcionStr As String = Console.ReadLine().Trim()
                    ' hola -> OpcionStr = "hola"
                    Dim Opcion As Byte = 0

                    ' Byte.TryParse intenta convertir el texto a número Byte
                    ' Devuelve True si la conversión fue exitosa, False si falló
                    ' Si tiene éxito, almacena el valor en la variable Opcion
                    ' Opcion = al valor convertido ya a Byte
                    If Byte.TryParse(OpcionStr, Opcion) Then
                        If Opcion = 1 Then
                            ' ============================================================
                            ' AGREGAR PRODUCTO AL CARRITO
                            ' ============================================================
                            Console.Write(vbCrLf & "Ingrese número de producto (1-3): ")
                            Dim ProdNumStr As String = Console.ReadLine().Trim()
                            Dim ProdNum As Integer = 0

                            ' Integer.TryParse funciona igual que Byte.TryParse pero para enteros más grandes
                            ' Además validamos que esté en el rango 1-3
                            If Integer.TryParse(ProdNumStr, ProdNum) AndAlso ProdNum >= 1 AndAlso ProdNum <= 3 Then
                                Console.Write("Cantidad a comprar: ")
                                Dim CantidadStr As String = Console.ReadLine().Trim()
                                Dim Cantidad As Integer = 0

                                ' Validamos que la cantidad sea un número positivo
                                If Integer.TryParse(CantidadStr, Cantidad) AndAlso Cantidad > 0 Then
                                    ' ====================================================
                                    ' DETERMINAR PRECIO SEGÚN TIPO DE CLIENTE Y PRODUCTO
                                    ' ====================================================
                                    Dim PrecioUnitario As Double = 0.0
                                    Dim StockActual As Integer = 0
                                    Dim ProductoSeleccionado As String = ""

                                    ' Usamos If-ElseIf para manejar cada producto
                                    If ProdNum = 1 Then
                                        ProductoSeleccionado = NombreProducto1
                                        StockActual = StockProducto1
                                        ' Determinamos el precio según el tipo de cliente
                                        If Tipo = "Regular" Then
                                            PrecioUnitario = PrecioRegularProducto1
                                        ElseIf Tipo = "Mayorista" Then
                                            PrecioUnitario = PrecioMayoristaProducto1
                                        ElseIf Tipo = "Premium" Then
                                            PrecioUnitario = PrecioPremiumProducto1
                                        End If

                                    ElseIf ProdNum = 2 Then
                                        ProductoSeleccionado = NombreProducto2
                                        StockActual = StockProducto2
                                        If Tipo = "Regular" Then
                                            PrecioUnitario = PrecioRegularProducto2
                                        ElseIf Tipo = "Mayorista" Then
                                            PrecioUnitario = PrecioMayoristaProducto2
                                        ElseIf Tipo = "Premium" Then
                                            PrecioUnitario = PrecioPremiumProducto2
                                        End If

                                    ElseIf ProdNum = 3 Then
                                        ProductoSeleccionado = NombreProducto3
                                        StockActual = StockProducto3
                                        If Tipo = "Regular" Then
                                            PrecioUnitario = PrecioRegularProducto3
                                        ElseIf Tipo = "Mayorista" Then
                                            PrecioUnitario = PrecioMayoristaProducto3
                                        ElseIf Tipo = "Premium" Then
                                            PrecioUnitario = PrecioPremiumProducto3
                                        End If
                                    End If

                                    ' ================================================
                                    ' VERIFICAR STOCK Y PROCESAR COMPRA
                                    ' ================================================
                                    If Cantidad <= StockActual Then
                                        ' Calculamos el costo de este producto y lo sumamos al subtotal
                                        ' El operador += suma el valor a la variable (equivale a: Subtotal = Subtotal + ...)
                                        Subtotal += Cantidad * PrecioUnitario

                                        Console.WriteLine("¡Producto agregado! Total: Q" & (Cantidad * PrecioUnitario).ToString("F2"))

                                        ' ============================================
                                        ' ACTUALIZAR STOCK Y REGISTRAR COMPRA
                                        ' ============================================
                                        ' Disminuimos el stock y registramos la cantidad para el cliente actual
                                        If ProdNum = 1 Then
                                            ' El operador -= resta el valor de la variable
                                            StockProducto1 -= Cantidad
                                            ' Asignamos la cantidad al cliente correspondiente
                                            If NumClientes = 1 Then
                                                CantidadProducto1Cliente1 = Cantidad
                                            ElseIf NumClientes = 2 Then
                                                CantidadProducto1Cliente2 = Cantidad
                                            ElseIf NumClientes = 3 Then
                                                CantidadProducto1Cliente3 = Cantidad
                                            End If
                                            ComproDetergente = True
                                            NumProductosDiferentes += 1

                                        ElseIf ProdNum = 2 Then
                                            StockProducto2 -= Cantidad
                                            If NumClientes = 1 Then
                                                CantidadProducto2Cliente1 = Cantidad
                                            ElseIf NumClientes = 2 Then
                                                CantidadProducto2Cliente2 = Cantidad
                                            ElseIf NumClientes = 3 Then
                                                CantidadProducto2Cliente3 = Cantidad
                                            End If
                                            NumProductosDiferentes += 1

                                        ElseIf ProdNum = 3 Then
                                            StockProducto3 -= Cantidad
                                            If NumClientes = 1 Then
                                                CantidadProducto3Cliente1 = Cantidad
                                            ElseIf NumClientes = 2 Then
                                                CantidadProducto3Cliente2 = Cantidad
                                            ElseIf NumClientes = 3 Then
                                                CantidadProducto3Cliente3 = Cantidad
                                            End If
                                            ComproCloro = True
                                            NumProductosDiferentes += 1
                                        End If
                                    Else
                                        Console.WriteLine("ERROR: Stock insuficiente. Solo hay " & StockActual & " unidades disponibles.")
                                    End If
                                Else
                                    Console.WriteLine("ERROR: Cantidad inválida. Debe ser un número mayor a 0.")
                                End If

                            Else
                                Console.WriteLine("ERROR: Producto inválido. Debe elegir un número entre 1 y 3.")
                            End If
                        ElseIf Opcion = 2 Then
                            ' Finalizar compra: cambiamos el boolean para salir del bucle
                            ContinuarCompra = False
                        Else
                            Console.WriteLine("ERROR: Opción inválida. Debe ser 1 o 2.")
                        End If
                    Else
                        Console.WriteLine("ERROR: Debe ingresar un número válido.")
                    End If
                Loop While ContinuarCompra

                ' El bucle se repite mientras ContinuarCompra sea True

                ' ====================================================================
                ' CÁLCULO DE DESCUENTOS
                ' ====================================================================
                ' El sistema aplica 3 tipos de descuentos independientes:

                ' Descuento 1: 10% para clientes Mayorista que compren los 3 productos
                ' incluyendo Detergente y Cloro  -> 10.2, 5.5

                Dim Descuento1 As Double = 0.0
                If Tipo = "Mayorista" And NumProductosDiferentes = 3 And ComproDetergente And ComproCloro Then
                    Descuento1 = Subtotal * 0.1
                End If

                ' Descuento 2: 15% si el subtotal supera Q50.00
                Dim Descuento2 As Double = 0.0
                If Subtotal > 50.0 Then
                    Descuento2 = Subtotal * 0.15
                End If

                ' Descuento 3: 5% adicional si la compra se realiza en fin de semana
                Dim DescuentoFinSemana As Double = 0.0
                If EsFinDeSemana Then
                    DescuentoFinSemana = Subtotal * 0.05
                End If

                ' Calculamos el total final restando todos los descuentos del subtotal
                Dim TotalCliente As Double = Subtotal - Descuento1 - Descuento2 - DescuentoFinSemana

                ' Guardamos el subtotal en la variable del cliente correspondiente
                If NumClientes = 1 Then
                    SubtotalCliente1 = Subtotal
                ElseIf NumClientes = 2 Then
                    SubtotalCliente2 = Subtotal
                ElseIf NumClientes = 3 Then
                    SubtotalCliente3 = Subtotal
                End If

                ' ====================================================================
                ' MOSTRAR RESUMEN DE COMPRA DEL CLIENTE
                ' ====================================================================
                Console.WriteLine(vbCrLf & "========== RESUMEN DE COMPRA ==========")
                Console.WriteLine("Cliente: " & Nombre & " (" & Tipo & ")")
                Console.WriteLine(vbCrLf & "Productos comprados:")

                If NumClientes = 1 Then
                    If CantidadProducto1Cliente1 > 0 Then
                        Dim PrecioMostrar1 As Double = 0.0    ' 10
                        If Tipo = "Regular" Then
                            PrecioMostrar1 = PrecioRegularProducto1
                        ElseIf Tipo = "Mayorista" Then
                            PrecioMostrar1 = PrecioMayoristaProducto1
                        ElseIf Tipo = "Premium" Then
                            PrecioMostrar1 = PrecioPremiumProducto1
                        End If
                        Console.WriteLine("  - " & NombreProducto1 & ": " & CantidadProducto1Cliente1 & " x Q" & PrecioMostrar1.ToString("F2") & " = Q" & (CantidadProducto1Cliente1 * PrecioMostrar1).ToString("F2"))
                    End If
                    If CantidadProducto2Cliente1 > 0 Then
                        Dim PrecioMostrar2 As Double = 0.0
                        If Tipo = "Regular" Then
                            PrecioMostrar2 = PrecioRegularProducto2
                        ElseIf Tipo = "Mayorista" Then
                            PrecioMostrar2 = PrecioMayoristaProducto2
                        ElseIf Tipo = "Premium" Then
                            PrecioMostrar2 = PrecioPremiumProducto2
                        End If
                        Console.WriteLine("  - " & NombreProducto2 & ": " & CantidadProducto2Cliente1 & " x Q" & PrecioMostrar2.ToString("F2") & " = Q" & (CantidadProducto2Cliente1 * PrecioMostrar2).ToString("F2"))
                    End If
                    If CantidadProducto3Cliente1 > 0 Then
                        Dim PrecioMostrar3 As Double = 0.0
                        If Tipo = "Regular" Then
                            PrecioMostrar3 = PrecioRegularProducto3
                        ElseIf Tipo = "Mayorista" Then
                            PrecioMostrar3 = PrecioMayoristaProducto3
                        ElseIf Tipo = "Premium" Then
                            PrecioMostrar3 = PrecioPremiumProducto3
                        End If
                        Console.WriteLine("  - " & NombreProducto3 & ": " & CantidadProducto3Cliente1 & " x Q" & PrecioMostrar3.ToString("F2") & " = Q" & (CantidadProducto3Cliente1 * PrecioMostrar3).ToString("F2"))
                    End If
                ElseIf NumClientes = 2 Then
                    If CantidadProducto1Cliente2 > 0 Then
                        Dim PrecioMostrar1 As Double = 0.0
                        If Tipo = "Regular" Then
                            PrecioMostrar1 = PrecioRegularProducto1
                        ElseIf Tipo = "Mayorista" Then
                            PrecioMostrar1 = PrecioMayoristaProducto1
                        ElseIf Tipo = "Premium" Then
                            PrecioMostrar1 = PrecioPremiumProducto1
                        End If
                        Console.WriteLine("  - " & NombreProducto1 & ": " & CantidadProducto1Cliente2 & " x Q" & PrecioMostrar1.ToString("F2") & " = Q" & (CantidadProducto1Cliente2 * PrecioMostrar1).ToString("F2"))
                    End If

                    If CantidadProducto2Cliente2 > 0 Then
                        Dim PrecioMostrar2 As Double = 0.0
                        If Tipo = "Regular" Then
                            PrecioMostrar2 = PrecioRegularProducto2
                        ElseIf Tipo = "Mayorista" Then
                            PrecioMostrar2 = PrecioMayoristaProducto2
                        ElseIf Tipo = "Premium" Then
                            PrecioMostrar2 = PrecioPremiumProducto2
                        End If
                        Console.WriteLine("  - " & NombreProducto2 & ": " & CantidadProducto2Cliente2 & " x Q" & PrecioMostrar2.ToString("F2") & " = Q" & (CantidadProducto2Cliente2 * PrecioMostrar2).ToString("F2"))
                    End If

                    If CantidadProducto3Cliente2 > 0 Then
                        Dim PrecioMostrar3 As Double = 0.0
                        If Tipo = "Regular" Then
                            PrecioMostrar3 = PrecioRegularProducto3
                        ElseIf Tipo = "Mayorista" Then
                            PrecioMostrar3 = PrecioMayoristaProducto3
                        ElseIf Tipo = "Premium" Then
                            PrecioMostrar3 = PrecioPremiumProducto3
                        End If
                        Console.WriteLine("  - " & NombreProducto3 & ": " & CantidadProducto3Cliente2 & " x Q" & PrecioMostrar3.ToString("F2") & " = Q" & (CantidadProducto3Cliente2 * PrecioMostrar3).ToString("F2"))
                    End If

                ElseIf NumClientes = 3 Then
                    If CantidadProducto1Cliente3 > 0 Then
                        Dim PrecioMostrar1 As Double = 0.0
                        If Tipo = "Regular" Then
                            PrecioMostrar1 = PrecioRegularProducto1
                        ElseIf Tipo = "Mayorista" Then
                            PrecioMostrar1 = PrecioMayoristaProducto1
                        ElseIf Tipo = "Premium" Then
                            PrecioMostrar1 = PrecioPremiumProducto1
                        End If
                        Console.WriteLine("  - " & NombreProducto1 & ": " & CantidadProducto1Cliente3 & " x Q" & PrecioMostrar1.ToString("F2") & " = Q" & (CantidadProducto1Cliente3 * PrecioMostrar1).ToString("F2"))
                    End If

                    If CantidadProducto2Cliente3 > 0 Then
                        Dim PrecioMostrar2 As Double = 0.0
                        If Tipo = "Regular" Then
                            PrecioMostrar2 = PrecioRegularProducto2
                        ElseIf Tipo = "Mayorista" Then
                            PrecioMostrar2 = PrecioMayoristaProducto2
                        ElseIf Tipo = "Premium" Then
                            PrecioMostrar2 = PrecioPremiumProducto2
                        End If
                        Console.WriteLine("  - " & NombreProducto2 & ": " & CantidadProducto2Cliente3 & " x Q" & PrecioMostrar2.ToString("F2") & " = Q" & (CantidadProducto2Cliente3 * PrecioMostrar2).ToString("F2"))
                    End If

                    If CantidadProducto3Cliente3 > 0 Then
                        Dim PrecioMostrar3 As Double = 0.0
                        If Tipo = "Regular" Then
                            PrecioMostrar3 = PrecioRegularProducto3
                        ElseIf Tipo = "Mayorista" Then
                            PrecioMostrar3 = PrecioMayoristaProducto3
                        ElseIf Tipo = "Premium" Then
                            PrecioMostrar3 = PrecioPremiumProducto3
                        End If
                        Console.WriteLine("  - " & NombreProducto3 & ": " & CantidadProducto3Cliente3 & " x Q" & PrecioMostrar3.ToString("F2") & " = Q" & (CantidadProducto3Cliente3 * PrecioMostrar3).ToString("F2"))
                    End If

                    ' Mostramos el desglose financiero
                End If
                Console.WriteLine(vbCrLf & "Subtotal: Q" & Subtotal.ToString("F2"))
                Console.WriteLine("Descuento Mayorista (10%): -Q" & Descuento1.ToString("F2"))
                Console.WriteLine("Descuento por monto (15%): -Q" & Descuento2.ToString("F2"))
                Console.WriteLine("Descuento fin de semana (5%): -Q" & DescuentoFinSemana.ToString("F2"))
                Console.WriteLine("----------------------------------------")
                Console.WriteLine("TOTAL A PAGAR: Q" & TotalCliente.ToString("F2"))
                Console.WriteLine("========================================")
            End If
        End While



        ' ========================================================================
        ' REPORTE GENERAL DEL SISTEMA
        ' ========================================================================
        ' Solo mostramos el reporte si hay al menos un cliente registrado

        If NumClientes > 0 Then
            ' Calculamos el total de ventas sumando los subtotales de todos los clientes
            Dim TotalVentas As Double = SubtotalCliente1 + SubtotalCliente2 + SubtotalCliente3

            ' Calculamos el promedio dividiendo el total entre el número de clientes
            ' El operador / realiza división decimal (con decimales)
            Dim PromedioSubtotal As Double = TotalVentas / NumClientes

            ' ====================================================================
            ' DETERMINAR CLIENTE CON MAYOR COMPRA
            ' ====================================================================
            ' Iniciamos asumiendo que el cliente 1 tiene la mayor compra
            Dim MaxCompra As Double = SubtotalCliente1
            Dim ClienteMax As String = NombreCliente1


            ' Comparamos con el cliente 2
            ' El operador > significa "mayor que"
            If SubtotalCliente2 > MaxCompra Then
                MaxCompra = SubtotalCliente2
                ClienteMax = NombreCliente2
            End If

            ' Comparamos con el cliente 3
            If SubtotalCliente3 > MaxCompra Then
                MaxCompra = SubtotalCliente3
                ClienteMax = NombreCliente3
            End If

            ' ====================================================================
            ' DETERMINAR PRODUCTO MÁS VENDIDO
            ' ====================================================================
            ' Sumamos las cantidades vendidas de cada producto a todos los clientes
            Dim VentasProducto1 As Integer = CantidadProducto1Cliente1 + CantidadProducto1Cliente2 + CantidadProducto1Cliente3
            Dim VentasProducto2 As Integer = CantidadProducto2Cliente1 + CantidadProducto2Cliente2 + CantidadProducto2Cliente3
            Dim VentasProducto3 As Integer = CantidadProducto3Cliente1 + CantidadProducto3Cliente2 + CantidadProducto3Cliente3

            ' Iniciamos asumiendo que el producto 1 es el más vendido
            Dim MaxVentas As Integer = VentasProducto1
            Dim ProdMax As String = NombreProducto1

            ' Comparamos con los demás productos
            If VentasProducto2 > MaxVentas Then
                MaxVentas = VentasProducto2
                ProdMax = NombreProducto2
            End If

            If VentasProducto3 > MaxVentas Then
                MaxVentas = VentasProducto3
                ProdMax = NombreProducto3
            End If

            ' Mostramos el reporte general con todas las estadísticas
            Console.WriteLine(vbCrLf & "╔════════════════════════════════════════════╗")
            Console.WriteLine("║        REPORTE GENERAL DEL DÍA             ║")
            Console.WriteLine("╚════════════════════════════════════════════╝")
            Console.WriteLine("Total de ventas (subtotales): Q" & TotalVentas.ToString("F2"))
            Console.WriteLine("Promedio de subtotal por cliente: Q" & PromedioSubtotal.ToString("F2"))
            Console.WriteLine("Cliente con mayor compra: " & ClienteMax & " (Q" & MaxCompra.ToString("F2") & ")")
            Console.WriteLine("Producto más vendido: " & ProdMax & " (" & MaxVentas & " unidades)")

            ' ====================================================================
            ' DETALLE DE COMPRAS POR CLIENTE
            ' ====================================================================
            Console.WriteLine(vbCrLf & "========== DETALLE DE COMPRAS ==========")

            ' Mostramos las compras del cliente 1 si existe
            ' "" representa una cadena vacía (String vacío)
            If NombreCliente1 <> "" Then
                Console.WriteLine(vbCrLf & "Cliente: " & NombreCliente1 & " (" & TipoCliente1 & ")")
                Console.WriteLine("Productos comprados:")

                If CantidadProducto1Cliente1 > 0 Then
                    Console.WriteLine("  - " & NombreProducto1 & ": " & CantidadProducto1Cliente1 & " unidades")
                End If
                If CantidadProducto2Cliente1 > 0 Then
                    Console.WriteLine("  - " & NombreProducto2 & ": " & CantidadProducto2Cliente1 & " unidades")
                End If
                If CantidadProducto3Cliente1 > 0 Then
                    Console.WriteLine("  - " & NombreProducto3 & ": " & CantidadProducto3Cliente1 & " unidades")
                End If
                Console.WriteLine("Subtotal: Q" & SubtotalCliente1.ToString("F2"))
            End If

            ' Mostramos las compras del cliente 2 si existe
            If NombreCliente2 <> "" Then
                Console.WriteLine(vbCrLf & "Cliente: " & NombreCliente2 & " (" & TipoCliente2 & ")")
                Console.WriteLine("Productos comprados:")

                If CantidadProducto1Cliente2 > 0 Then
                    Console.WriteLine("  - " & NombreProducto1 & ": " & CantidadProducto1Cliente2 & " unidades")
                End If
                If CantidadProducto2Cliente2 > 0 Then
                    Console.WriteLine("  - " & NombreProducto2 & ": " & CantidadProducto2Cliente2 & " unidades")
                End If
                If CantidadProducto3Cliente2 > 0 Then
                    Console.WriteLine("  - " & NombreProducto3 & ": " & CantidadProducto3Cliente2 & " unidades")
                End If
                Console.WriteLine("Subtotal: Q" & SubtotalCliente2.ToString("F2"))
            End If

            ' Mostramos las compras del cliente 3 si existe
            If NombreCliente3 <> "" Then
                Console.WriteLine(vbCrLf & "Cliente: " & NombreCliente3 & " (" & TipoCliente3 & ")")
                Console.WriteLine("Productos comprados:")

                If CantidadProducto1Cliente3 > 0 Then
                    Console.WriteLine("  - " & NombreProducto1 & ": " & CantidadProducto1Cliente3 & " unidades")
                End If
                If CantidadProducto2Cliente3 > 0 Then
                    Console.WriteLine("  - " & NombreProducto2 & ": " & CantidadProducto2Cliente3 & " unidades")
                End If
                If CantidadProducto3Cliente3 > 0 Then
                    Console.WriteLine("  - " & NombreProducto3 & ": " & CantidadProducto3Cliente3 & " unidades")
                End If
                Console.WriteLine("Subtotal: Q" & SubtotalCliente3.ToString("F2"))
            End If

            Console.WriteLine("========================================")
        Else
            ' Si no hay clientes registrados, mostramos este mensaje
            Console.WriteLine(vbCrLf & "No se registraron clientes durante esta sesión.")
        End If

        ' Pausa final para que el usuario pueda leer los resultados antes de cerrar
        Console.WriteLine(vbCrLf & "Presione cualquier tecla para salir del sistema...")
        ' Console.ReadKey() espera a que el usuario presione cualquier tecla
        Console.ReadKey()
    End Sub
End Module
