Public Module ModEnumations

    Public Enum EnumFuelKnown
        FuelKnown
        FuelNotKnown
        FuelOther
    End Enum


    Public Enum EnumfuelType
        Gasolina
        Diesel
        'OtraFuenteDeEnergia
    End Enum

    Public Enum EnumEqmtPriceEstType
        Maquinaria1
        Maquinaria2
        Maquinaria3
        Maquinaria4
        Herramienta1
    End Enum
    Public Enum EnumInsumos
        Materiales
        Equipos
        Herramientas
        Transporte
        ManoDeObra
    End Enum

    Public Enum EnumPartidaTypeForm
        CIV
        MEX
        ARG
        ATN
        USA
    End Enum

    'Public Enum EnumPriceAnalysisType
    '    Partida
    '    Obra
    'End Enum

    Public Enum EnumPresupuestoType
        None
        IsByChapter
        IsByStage
    End Enum

    Public Enum EnumDisplayType
        Display
        Edit
        [New]
    End Enum

End Module
