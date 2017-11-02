<?xml version="1.0" encoding="utf-8"?>
<Dsl xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="c8af8293-d69f-4584-989c-50394575205f" Description="Description for Ufba.visualForm.visualForm" Name="visualForm" DisplayName="visualForm" Namespace="Ufba.visualForm" ProductName="visualForm" CompanyName="Ufba" PackageGuid="a3bfe338-0dc8-4aa8-8a41-56820c85dbac" PackageNamespace="Ufba.visualForm" xmlns="http://schemas.microsoft.com/VisualStudio/2005/DslTools/DslDefinitionModel">
  <Classes>
    <DomainClass Id="0065f1d6-000e-44ac-bd45-743db4e444a1" Description="The root in which all other elements are embedded. Appears as a diagram." Name="FormModel" DisplayName="Form Model" Namespace="Ufba.visualForm">
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Notes>Creates an embedding link when an element is dropped onto a model. </Notes>
          <Index>
            <DomainClassMoniker Name="Form" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>FormModelHasElements.Elements</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="0f56c2ab-86bd-409d-b2ea-9ca392397f0e" Description="Elements embedded in the model. Appear as boxes on the diagram." Name="Form" DisplayName="Form" Namespace="Ufba.visualForm">
      <Properties>
        <DomainProperty Id="93b822a3-537e-4ad2-a721-5454bd2624fa" Description="Description for Ufba.visualForm.Form.Name" Name="Name" DisplayName="Name" DefaultValue="" IsElementName="true">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="Field" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>FormHasFields.Fields</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="fc2a54be-8983-4477-aea7-dbd0cc5915bb" Description="Description for Ufba.visualForm.Field" Name="Field" DisplayName="Field" Namespace="Ufba.visualForm">
      <Properties>
        <DomainProperty Id="78a2ea69-fa76-4d7e-9d95-6fa27a7487e8" Description="Description for Ufba.visualForm.Field.Name" Name="Name" DisplayName="Name">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="9ce27032-167d-452f-995c-7056a160585d" Description="Description for Ufba.visualForm.Field.Type" Name="Type" DisplayName="Type">
          <Type>
            <DomainEnumerationMoniker Name="FieldType" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="d8acf008-2485-4461-be81-c08ef2ead785" Description="Description for Ufba.visualForm.Field.Required" Name="Required" DisplayName="Required">
          <Type>
            <ExternalTypeMoniker Name="/System/Boolean" />
          </Type>
        </DomainProperty>
      </Properties>
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="Option" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>FieldHasOptions.Options</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="8161a441-8c02-443b-8a0b-031833caf0a3" Description="Description for Ufba.visualForm.Option" Name="Option" DisplayName="Option" Namespace="Ufba.visualForm">
      <Properties>
        <DomainProperty Id="b87777a2-6138-40ef-8aad-935e7989a6f2" Description="Description for Ufba.visualForm.Option.Name" Name="Name" DisplayName="Name">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
  </Classes>
  <Relationships>
    <DomainRelationship Id="b85919e7-c8d5-4c02-a30a-028057cafde3" Description="Embedding relationship between the Model and Elements" Name="FormModelHasElements" DisplayName="Form Model Has Elements" Namespace="Ufba.visualForm" IsEmbedding="true">
      <Source>
        <DomainRole Id="b3d25977-077d-4ddb-baee-fb8ed4c18953" Description="" Name="FormModel" DisplayName="Form Model" PropertyName="Elements" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Elements">
          <RolePlayer>
            <DomainClassMoniker Name="FormModel" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="d914a7bf-f84a-46b8-8b4f-51192ed927c9" Description="" Name="Element" DisplayName="Element" PropertyName="FormModel" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Form Model">
          <RolePlayer>
            <DomainClassMoniker Name="Form" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="b5b0cef9-5f2d-4c27-b715-cbd5df5c58b7" Description="Description for Ufba.visualForm.FormHasFields" Name="FormHasFields" DisplayName="Form Has Fields" Namespace="Ufba.visualForm" IsEmbedding="true">
      <Source>
        <DomainRole Id="56d7699c-f9b1-44f0-9981-ba721ebcfe3d" Description="Description for Ufba.visualForm.FormHasFields.Form" Name="Form" DisplayName="Form" PropertyName="Fields" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Fields">
          <RolePlayer>
            <DomainClassMoniker Name="Form" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="7583647e-bdd5-4e01-be55-c723d061cc4b" Description="Description for Ufba.visualForm.FormHasFields.Field" Name="Field" DisplayName="Field" PropertyName="Form" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Form">
          <RolePlayer>
            <DomainClassMoniker Name="Field" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="a918d1b4-a0e5-4900-b371-a211456714f7" Description="Description for Ufba.visualForm.FieldHasOptions" Name="FieldHasOptions" DisplayName="Field Has Options" Namespace="Ufba.visualForm" IsEmbedding="true">
      <Source>
        <DomainRole Id="abbd89c5-183c-41ba-a1fc-2bb4b6b4e363" Description="Description for Ufba.visualForm.FieldHasOptions.Field" Name="Field" DisplayName="Field" PropertyName="Options" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Options">
          <RolePlayer>
            <DomainClassMoniker Name="Field" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="8306791b-7955-4538-8602-b97ebc7840f5" Description="Description for Ufba.visualForm.FieldHasOptions.Option" Name="Option" DisplayName="Option" PropertyName="Field" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Field">
          <RolePlayer>
            <DomainClassMoniker Name="Option" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
  </Relationships>
  <Types>
    <ExternalType Name="DateTime" Namespace="System" />
    <ExternalType Name="String" Namespace="System" />
    <ExternalType Name="Int16" Namespace="System" />
    <ExternalType Name="Int32" Namespace="System" />
    <ExternalType Name="Int64" Namespace="System" />
    <ExternalType Name="UInt16" Namespace="System" />
    <ExternalType Name="UInt32" Namespace="System" />
    <ExternalType Name="UInt64" Namespace="System" />
    <ExternalType Name="SByte" Namespace="System" />
    <ExternalType Name="Byte" Namespace="System" />
    <ExternalType Name="Double" Namespace="System" />
    <ExternalType Name="Single" Namespace="System" />
    <ExternalType Name="Guid" Namespace="System" />
    <ExternalType Name="Boolean" Namespace="System" />
    <ExternalType Name="Char" Namespace="System" />
    <DomainEnumeration Name="FieldType" Namespace="Ufba.visualForm" Description="Description for Ufba.visualForm.FieldType">
      <Literals>
        <EnumerationLiteral Description="Description for Ufba.visualForm.FieldType.text" Name="text" Value="" />
        <EnumerationLiteral Description="Description for Ufba.visualForm.FieldType.integer" Name="integer" Value="" />
        <EnumerationLiteral Description="Description for Ufba.visualForm.FieldType.date" Name="date" Value="" />
        <EnumerationLiteral Description="Description for Ufba.visualForm.FieldType.email" Name="email" Value="" />
        <EnumerationLiteral Description="Description for Ufba.visualForm.FieldType.check" Name="check" Value="" />
        <EnumerationLiteral Description="Description for Ufba.visualForm.FieldType.radio" Name="radio" Value="" />
        <EnumerationLiteral Description="Description for Ufba.visualForm.FieldType.textarea" Name="textarea" Value="" />
        <EnumerationLiteral Description="Description for Ufba.visualForm.FieldType.selectBox" Name="selectBox" Value="" />
        <EnumerationLiteral Description="Description for Ufba.visualForm.FieldType.comboBox" Name="comboBox" Value="" />
        <EnumerationLiteral Description="Description for Ufba.visualForm.FieldType.file" Name="file" Value="" />
      </Literals>
    </DomainEnumeration>
    <DomainEnumeration Name="Order" Namespace="Ufba.visualForm" Description="Description for Ufba.visualForm.Order">
      <Literals>
        <EnumerationLiteral Description="Description for Ufba.visualForm.Order.ASC" Name="ASC" Value="" />
        <EnumerationLiteral Description="Description for Ufba.visualForm.Order.DESC" Name="DESC" Value="" />
      </Literals>
    </DomainEnumeration>
  </Types>
  <Shapes>
    <GeometryShape Id="22bc175d-9b05-4564-a697-ce33bf1dfeca" Description="Shape used to represent ExampleElements on a Diagram." Name="FormShape" DisplayName="Form Shape" Namespace="Ufba.visualForm" FixedTooltipText="Form Shape" FillColor="255, 224, 192" OutlineColor="113, 111, 110" InitialWidth="2" InitialHeight="0.75" OutlineThickness="0.01" Geometry="Rectangle">
      <Notes>The shape has a text decorator used to display the Name property of the mapped ExampleElement.</Notes>
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="NameDecorator" DisplayName="Name Decorator" DefaultText="NameDecorator" />
      </ShapeHasDecorators>
    </GeometryShape>
    <GeometryShape Id="b98df907-61f6-4650-80ed-b467d1010101" Description="Description for Ufba.visualForm.FieldShape" Name="FieldShape" DisplayName="Field Shape" Namespace="Ufba.visualForm" FixedTooltipText="Field Shape" FillColor="224, 224, 224" InitialHeight="0.8" Geometry="RoundedRectangle">
      <ShapeHasDecorators Position="InnerTopCenter" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Name" DisplayName="Name" DefaultText="Name" />
      </ShapeHasDecorators>
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Type" DisplayName="Type" DefaultText="Type" />
      </ShapeHasDecorators>
      <ShapeHasDecorators Position="InnerBottomCenter" HorizontalOffset="0" VerticalOffset="0">
        <IconDecorator Name="Required" DisplayName="Required" DefaultIcon="Resources\exclamation2.bmp" />
      </ShapeHasDecorators>
    </GeometryShape>
    <GeometryShape Id="8117b3aa-31ce-450a-a8ee-6818c55fa3e2" Description="Description for Ufba.visualForm.OptionShape" Name="OptionShape" DisplayName="Option Shape" Namespace="Ufba.visualForm" FixedTooltipText="Option Shape" FillColor="255, 255, 128" InitialHeight="0.4" Geometry="Ellipse">
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Name" DisplayName="Name" DefaultText="Name" />
      </ShapeHasDecorators>
    </GeometryShape>
  </Shapes>
  <Connectors>
    <Connector Id="d160b663-8a53-4033-9fe5-52e2d73813ec" Description="Connector between the ExampleShapes. Represents ExampleRelationships on the Diagram." Name="FieldConnector" DisplayName="Field Connector" Namespace="Ufba.visualForm" FixedTooltipText="Field Connector" Color="113, 111, 110" TargetEndStyle="EmptyArrow" Thickness="0.01" />
    <Connector Id="335d35ea-9662-43ab-9edc-ecd5fa425455" Description="Description for Ufba.visualForm.OptionConnector" Name="OptionConnector" DisplayName="Option Connector" Namespace="Ufba.visualForm" FixedTooltipText="Option Connector" TargetEndStyle="EmptyArrow" />
  </Connectors>
  <XmlSerializationBehavior Name="visualFormSerializationBehavior" Namespace="Ufba.visualForm">
    <ClassData>
      <XmlClassData TypeName="FormModel" MonikerAttributeName="" SerializeId="true" MonikerElementName="formModelMoniker" ElementName="formModel" MonikerTypeName="FormModelMoniker">
        <DomainClassMoniker Name="FormModel" />
        <ElementData>
          <XmlRelationshipData RoleElementName="elements">
            <DomainRelationshipMoniker Name="FormModelHasElements" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="Form" MonikerAttributeName="name" SerializeId="true" MonikerElementName="formMoniker" ElementName="form" MonikerTypeName="FormMoniker">
        <DomainClassMoniker Name="Form" />
        <ElementData>
          <XmlPropertyData XmlName="name" IsMonikerKey="true">
            <DomainPropertyMoniker Name="Form/Name" />
          </XmlPropertyData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="fields">
            <DomainRelationshipMoniker Name="FormHasFields" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="FormModelHasElements" MonikerAttributeName="" SerializeId="true" MonikerElementName="formModelHasElementsMoniker" ElementName="formModelHasElements" MonikerTypeName="FormModelHasElementsMoniker">
        <DomainRelationshipMoniker Name="FormModelHasElements" />
      </XmlClassData>
      <XmlClassData TypeName="FormShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="formShapeMoniker" ElementName="formShape" MonikerTypeName="FormShapeMoniker">
        <GeometryShapeMoniker Name="FormShape" />
      </XmlClassData>
      <XmlClassData TypeName="FieldConnector" MonikerAttributeName="" SerializeId="true" MonikerElementName="fieldConnectorMoniker" ElementName="fieldConnector" MonikerTypeName="FieldConnectorMoniker">
        <ConnectorMoniker Name="FieldConnector" />
      </XmlClassData>
      <XmlClassData TypeName="visualFormDiagram" MonikerAttributeName="" SerializeId="true" MonikerElementName="visualFormDiagramMoniker" ElementName="visualFormDiagram" MonikerTypeName="VisualFormDiagramMoniker">
        <DiagramMoniker Name="visualFormDiagram" />
      </XmlClassData>
      <XmlClassData TypeName="Field" MonikerAttributeName="" SerializeId="true" MonikerElementName="fieldMoniker" ElementName="field" MonikerTypeName="FieldMoniker">
        <DomainClassMoniker Name="Field" />
        <ElementData>
          <XmlPropertyData XmlName="name">
            <DomainPropertyMoniker Name="Field/Name" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="type">
            <DomainPropertyMoniker Name="Field/Type" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="required">
            <DomainPropertyMoniker Name="Field/Required" />
          </XmlPropertyData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="options">
            <DomainRelationshipMoniker Name="FieldHasOptions" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="FormHasFields" MonikerAttributeName="" SerializeId="true" MonikerElementName="formHasFieldsMoniker" ElementName="formHasFields" MonikerTypeName="FormHasFieldsMoniker">
        <DomainRelationshipMoniker Name="FormHasFields" />
      </XmlClassData>
      <XmlClassData TypeName="FieldShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="fieldShapeMoniker" ElementName="fieldShape" MonikerTypeName="FieldShapeMoniker">
        <GeometryShapeMoniker Name="FieldShape" />
      </XmlClassData>
      <XmlClassData TypeName="Option" MonikerAttributeName="" SerializeId="true" MonikerElementName="optionMoniker" ElementName="option" MonikerTypeName="OptionMoniker">
        <DomainClassMoniker Name="Option" />
        <ElementData>
          <XmlPropertyData XmlName="name">
            <DomainPropertyMoniker Name="Option/Name" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="FieldHasOptions" MonikerAttributeName="" SerializeId="true" MonikerElementName="fieldHasOptionsMoniker" ElementName="fieldHasOptions" MonikerTypeName="FieldHasOptionsMoniker">
        <DomainRelationshipMoniker Name="FieldHasOptions" />
      </XmlClassData>
      <XmlClassData TypeName="OptionConnector" MonikerAttributeName="" SerializeId="true" MonikerElementName="optionConnectorMoniker" ElementName="optionConnector" MonikerTypeName="OptionConnectorMoniker">
        <ConnectorMoniker Name="OptionConnector" />
      </XmlClassData>
      <XmlClassData TypeName="OptionShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="optionShapeMoniker" ElementName="optionShape" MonikerTypeName="OptionShapeMoniker">
        <GeometryShapeMoniker Name="OptionShape" />
      </XmlClassData>
    </ClassData>
  </XmlSerializationBehavior>
  <ExplorerBehavior Name="visualFormExplorer" />
  <ConnectionBuilders>
    <ConnectionBuilder Name="FormHasFieldsBuilder">
      <LinkConnectDirective>
        <DomainRelationshipMoniker Name="FormHasFields" />
        <SourceDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="Form" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </SourceDirectives>
        <TargetDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="Field" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </TargetDirectives>
      </LinkConnectDirective>
    </ConnectionBuilder>
    <ConnectionBuilder Name="FieldHasOptionsBuilder">
      <LinkConnectDirective>
        <DomainRelationshipMoniker Name="FieldHasOptions" />
        <SourceDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="Field" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </SourceDirectives>
        <TargetDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="Option" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </TargetDirectives>
      </LinkConnectDirective>
    </ConnectionBuilder>
  </ConnectionBuilders>
  <Diagram Id="878e5ac9-9254-4b22-8e18-db810aee3b7c" Description="Description for Ufba.visualForm.visualFormDiagram" Name="visualFormDiagram" DisplayName="Minimal Language Diagram" Namespace="Ufba.visualForm">
    <Class>
      <DomainClassMoniker Name="FormModel" />
    </Class>
    <ShapeMaps>
      <ShapeMap>
        <DomainClassMoniker Name="Form" />
        <ParentElementPath>
          <DomainPath>FormModelHasElements.FormModel/!FormModel</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="FormShape/NameDecorator" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Form/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <GeometryShapeMoniker Name="FormShape" />
      </ShapeMap>
      <ShapeMap>
        <DomainClassMoniker Name="Field" />
        <ParentElementPath>
          <DomainPath>FormHasFields.Form/!Form/FormModelHasElements.FormModel/!FormModel</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="FieldShape/Name" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Field/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <DecoratorMap>
          <TextDecoratorMoniker Name="FieldShape/Type" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Field/Type" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <DecoratorMap>
          <IconDecoratorMoniker Name="FieldShape/Required" />
          <VisibilityPropertyPath>
            <DomainPropertyMoniker Name="Field/Required" />
            <PropertyFilters>
              <PropertyFilter FilteringValue="True" />
            </PropertyFilters>
          </VisibilityPropertyPath>
        </DecoratorMap>
        <GeometryShapeMoniker Name="FieldShape" />
      </ShapeMap>
      <ShapeMap>
        <DomainClassMoniker Name="Option" />
        <ParentElementPath>
          <DomainPath>FieldHasOptions.Field/!Field/FormHasFields.Form/!Form/FormModelHasElements.FormModel/!FormModel</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="OptionShape/Name" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Option/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <GeometryShapeMoniker Name="OptionShape" />
      </ShapeMap>
    </ShapeMaps>
    <ConnectorMaps>
      <ConnectorMap>
        <ConnectorMoniker Name="FieldConnector" />
        <DomainRelationshipMoniker Name="FormHasFields" />
      </ConnectorMap>
      <ConnectorMap>
        <ConnectorMoniker Name="OptionConnector" />
        <DomainRelationshipMoniker Name="FieldHasOptions" />
      </ConnectorMap>
    </ConnectorMaps>
  </Diagram>
  <Designer CopyPasteGeneration="CopyPasteOnly" FileExtension="vForm" EditorGuid="7b28abd5-fdc0-4dc1-aa74-593b0377e735">
    <RootClass>
      <DomainClassMoniker Name="FormModel" />
    </RootClass>
    <XmlSerializationDefinition CustomPostLoad="false">
      <XmlSerializationBehaviorMoniker Name="visualFormSerializationBehavior" />
    </XmlSerializationDefinition>
    <ToolboxTab TabText="visualForm">
      <ElementTool Name="Form" ToolboxIcon="C:\Users\ana.ufba\Documents\Visual Studio 2015\Projects\Language5\Dsl\Resources\ClassTool.bmp" Caption="Form" Tooltip="Create an ExampleElement" HelpKeyword="CreateExampleClassF1Keyword">
        <DomainClassMoniker Name="Form" />
      </ElementTool>
      <ElementTool Name="Field" ToolboxIcon="C:\Users\ana.ufba\Documents\Visual Studio 2015\Projects\Language5\Dsl\Resources\AttributeTool.bmp" Caption="Field" Tooltip="Field" HelpKeyword="Field">
        <DomainClassMoniker Name="Field" />
      </ElementTool>
      <ElementTool Name="Option" ToolboxIcon="C:\Users\ana.ufba\Documents\Visual Studio 2015\Projects\Language5\Dsl\Resources\MultipleAssociationTool.bmp" Caption="Option" Tooltip="Option" HelpKeyword="Option">
        <DomainClassMoniker Name="Option" />
      </ElementTool>
    </ToolboxTab>
    <Validation UsesMenu="true" UsesOpen="true" UsesSave="true" UsesLoad="true" />
    <DiagramMoniker Name="visualFormDiagram" />
  </Designer>
  <Explorer ExplorerGuid="e1fe9fcd-33d9-4314-9387-3384f415a58b" Title="visualForm Explorer">
    <ExplorerBehaviorMoniker Name="visualForm/visualFormExplorer" />
  </Explorer>
</Dsl>