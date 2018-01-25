module CoreModels


type KindOfAbsense =
    | Holiday
    | Sick
    | Wfh
    | Appointment


type Employee = {
    firstName : string
    lastName : string
    department : string
}


type PartOfDay =
    | Am
    | Pm


type Duration =
    | Days of int
    | LessThanADay of PartOfDay


type Absence = {
    kind : KindOfAbsense
    duration : Duration
    employee : Employee
}