
'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
 System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
Partial Public Class subtitle_script

    Private stylesField As List(Of subtitle_scriptStyle)

    Private eventsField As List(Of subtitle_scriptEvent)

    Private idField As String

    Private titleField As String

    Private play_res_xField As String

    Private play_res_yField As String

    Private lang_codeField As String

    Private lang_stringField As String

    Private createdField As String

    Private progress_stringField As String

    Private status_stringField As String

    Private wrap_styleField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlArrayItemAttribute("style", IsNullable:=False)>
    Public Property styles() As List(Of subtitle_scriptStyle)
        Get
            Return Me.stylesField
        End Get
        Set
            Me.stylesField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlArrayItemAttribute("event", IsNullable:=False)>
    Public Property events() As List(Of subtitle_scriptEvent)
        Get
            Return Me.eventsField
        End Get
        Set
            Me.eventsField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property id() As String
        Get
            Return Me.idField
        End Get
        Set
            Me.idField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property title() As String
        Get
            Return Me.titleField
        End Get
        Set
            Me.titleField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property play_res_x() As String
        Get
            Return Me.play_res_xField
        End Get
        Set
            Me.play_res_xField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property play_res_y() As String
        Get
            Return Me.play_res_yField
        End Get
        Set
            Me.play_res_yField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property lang_code() As String
        Get
            Return Me.lang_codeField
        End Get
        Set
            Me.lang_codeField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property lang_string() As String
        Get
            Return Me.lang_stringField
        End Get
        Set
            Me.lang_stringField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property created() As String
        Get
            Return Me.createdField
        End Get
        Set
            Me.createdField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property progress_string() As String
        Get
            Return Me.progress_stringField
        End Get
        Set
            Me.progress_stringField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property status_string() As String
        Get
            Return Me.status_stringField
        End Get
        Set
            Me.status_stringField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property wrap_style() As String
        Get
            Return Me.wrap_styleField
        End Get
        Set
            Me.wrap_styleField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class subtitle_scriptStyle

    Private idField As String

    Private nameField As String

    Private font_nameField As String

    Private font_sizeField As String

    Private primary_colourField As String

    Private secondary_colourField As String

    Private outline_colourField As String

    Private back_colourField As String

    Private boldField As String

    Private italicField As String

    Private underlineField As String

    Private strikeoutField As String

    Private scale_xField As String

    Private scale_yField As String

    Private spacingField As String

    Private angleField As String

    Private border_styleField As String

    Private outlineField As String

    Private shadowField As String

    Private alignmentField As String

    Private margin_lField As String

    Private margin_rField As String

    Private margin_vField As String

    Private encodingField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property id() As String
        Get
            Return Me.idField
        End Get
        Set
            Me.idField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property name() As String
        Get
            Return Me.nameField
        End Get
        Set
            Me.nameField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property font_name() As String
        Get
            Return Me.font_nameField
        End Get
        Set
            Me.font_nameField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property font_size() As String
        Get
            Return Me.font_sizeField
        End Get
        Set
            Me.font_sizeField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property primary_colour() As String
        Get
            Return Me.primary_colourField
        End Get
        Set
            Me.primary_colourField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property secondary_colour() As String
        Get
            Return Me.secondary_colourField
        End Get
        Set
            Me.secondary_colourField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property outline_colour() As String
        Get
            Return Me.outline_colourField
        End Get
        Set
            Me.outline_colourField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property back_colour() As String
        Get
            Return Me.back_colourField
        End Get
        Set
            Me.back_colourField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property bold() As String
        Get
            Return Me.boldField
        End Get
        Set
            Me.boldField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property italic() As String
        Get
            Return Me.italicField
        End Get
        Set
            Me.italicField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property underline() As String
        Get
            Return Me.underlineField
        End Get
        Set
            Me.underlineField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property strikeout() As String
        Get
            Return Me.strikeoutField
        End Get
        Set
            Me.strikeoutField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property scale_x() As String
        Get
            Return Me.scale_xField
        End Get
        Set
            Me.scale_xField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property scale_y() As String
        Get
            Return Me.scale_yField
        End Get
        Set
            Me.scale_yField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property spacing() As String
        Get
            Return Me.spacingField
        End Get
        Set
            Me.spacingField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property angle() As String
        Get
            Return Me.angleField
        End Get
        Set
            Me.angleField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property border_style() As String
        Get
            Return Me.border_styleField
        End Get
        Set
            Me.border_styleField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property outline() As String
        Get
            Return Me.outlineField
        End Get
        Set
            Me.outlineField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property shadow() As String
        Get
            Return Me.shadowField
        End Get
        Set
            Me.shadowField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property alignment() As String
        Get
            Return Me.alignmentField
        End Get
        Set
            Me.alignmentField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property margin_l() As String
        Get
            Return Me.margin_lField
        End Get
        Set
            Me.margin_lField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property margin_r() As String
        Get
            Return Me.margin_rField
        End Get
        Set
            Me.margin_rField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property margin_v() As String
        Get
            Return Me.margin_vField
        End Get
        Set
            Me.margin_vField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property encoding() As String
        Get
            Return Me.encodingField
        End Get
        Set
            Me.encodingField = Value
        End Set
    End Property
End Class

'''<remarks/>
<System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
Partial Public Class subtitle_scriptEvent

    Private idField As String

    Private startField As String

    Private endField As String

    Private styleField As String

    Private nameField As String

    Private margin_lField As String

    Private margin_rField As String

    Private margin_vField As String

    Private effectField As String

    Private textField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property id() As String
        Get
            Return Me.idField
        End Get
        Set
            Me.idField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property start() As String
        Get
            Return Me.startField
        End Get
        Set
            Me.startField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property [end]() As String
        Get
            Return Me.endField
        End Get
        Set
            Me.endField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property style() As String
        Get
            Return Me.styleField
        End Get
        Set
            Me.styleField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property name() As String
        Get
            Return Me.nameField
        End Get
        Set
            Me.nameField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property margin_l() As String
        Get
            Return Me.margin_lField
        End Get
        Set
            Me.margin_lField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property margin_r() As String
        Get
            Return Me.margin_rField
        End Get
        Set
            Me.margin_rField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property margin_v() As String
        Get
            Return Me.margin_vField
        End Get
        Set
            Me.margin_vField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property effect() As String
        Get
            Return Me.effectField
        End Get
        Set
            Me.effectField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property text() As String
        Get
            Return Me.textField
        End Get
        Set
            Me.textField = Value
        End Set
    End Property
End Class


