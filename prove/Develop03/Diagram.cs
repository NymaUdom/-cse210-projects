/*
                                        Program
                                        |
                                        |
                                        v
        +-------------------------------------------------------------------------------+
        | Scripture                 |       Reference          |                Word    |
        +-------------------------------------------------------------------------------+
        | _refrence: Reference      |   -book: string          |        _text: string   |
        | _word: listWord>          |   -chapter: int          |        _isHiden: bool  |<---------------------------------------------+
        |                           |   _verse: int            |                        |                                              |
        |                           |   _endinVerse: int       |                        |                                              |
        +_______________________________________________________________________________+                                              |
                |                                           \                                                                          |
                |                                            \                                                                         |
                |                                             \                                                                        |
                |                                              \                                                                       |
                |                                               v                                                                      |
        +-------V------------------------------------+         +---------------------------------------------------------+             |
        |Scripture(Refrence: Refrence, text : string)|          | Refrence(book: string, chapter: int, vers:)             |            |
        |Hiderandomword(Numberhiden: in) :void       |          | Refrence(book:string chapter: int, statvers:in, end:int)|            |
        | DisplayText() : strng                      |          | DiplayText(): string                                    |            |
        |completehiden() bool                        |           +--------------------------------------------------------+            |               
        ---------------------------------------------+                                                                                 |
                                                        +--------------------------+                                                      |
                                                        |Word(text, strin)         |                                                      |
                                                        |Hid(): void               |<-----------------------------------------------------+
                                                        |Show(): void              |
                                                        |sHiden(): bool            |
                                                        |Getdisplay(): string      |
                                                        +--------------------------+
*/
