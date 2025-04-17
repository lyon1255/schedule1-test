using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Management;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006C9 RID: 1737
	public class ObjectListFieldUI : MonoBehaviour
	{
		// Token: 0x06009BFC RID: 39932 RVA: 0x00278934 File Offset: 0x00276B34
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectListFieldUI()
		{
			Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ObjectListFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr);
			ObjectListFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			ObjectListFieldUI.NativeFieldInfoPtr_FieldText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "FieldText");
			ObjectListFieldUI.NativeFieldInfoPtr_InstructionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "InstructionText");
			ObjectListFieldUI.NativeFieldInfoPtr_ExtendedInstructionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "ExtendedInstructionText");
			ObjectListFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "FieldLabel");
			ObjectListFieldUI.NativeFieldInfoPtr_NoneSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "NoneSelected");
			ObjectListFieldUI.NativeFieldInfoPtr_MultipleSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "MultipleSelected");
			ObjectListFieldUI.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "Entries");
			ObjectListFieldUI.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "Button");
			ObjectListFieldUI.NativeFieldInfoPtr_EditIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "EditIcon");
			ObjectListFieldUI.NativeFieldInfoPtr_NoMultiEdit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "NoMultiEdit");
			ObjectListFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_ObjectListField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682453);
			ObjectListFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ObjectListField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682454);
			ObjectListFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_ObjectListField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682455);
			ObjectListFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682456);
			ObjectListFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682457);
			ObjectListFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682458);
			ObjectListFieldUI.NativeMethodInfoPtr_ObjectValid_Private_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682459);
			ObjectListFieldUI.NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682460);
			ObjectListFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682461);
		}

		// Token: 0x17003011 RID: 12305
		// (get) Token: 0x06009BFD RID: 39933 RVA: 0x00278AF4 File Offset: 0x00276CF4
		// (set) Token: 0x06009BFE RID: 39934 RVA: 0x00278B34 File Offset: 0x00276D34
		public unsafe List<ObjectListField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_ObjectListField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ObjectListField>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ObjectListField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009BFF RID: 39935 RVA: 0x00278B78 File Offset: 0x00276D78
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 276754, RefRangeEnd = 276758, XrefRangeStart = 276717, XrefRangeEnd = 276754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<ObjectListField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_ObjectListField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C00 RID: 39936 RVA: 0x00278BBC File Offset: 0x00276DBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276813, RefRangeEnd = 276814, XrefRangeStart = 276758, XrefRangeEnd = 276813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(List<BuildableItem> newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C01 RID: 39937 RVA: 0x00278C00 File Offset: 0x00276E00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276824, RefRangeEnd = 276826, XrefRangeStart = 276814, XrefRangeEnd = 276824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009C02 RID: 39938 RVA: 0x00278C3C File Offset: 0x00276E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276826, XrefRangeEnd = 276864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C03 RID: 39939 RVA: 0x00278C70 File Offset: 0x00276E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276864, XrefRangeEnd = 276875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ObjectValid(BuildableItem obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_ObjectValid_Private_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06009C04 RID: 39940 RVA: 0x00278CD8 File Offset: 0x00276ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276875, XrefRangeEnd = 276899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObjectsSelected(List<BuildableItem> objs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C05 RID: 39941 RVA: 0x00278D1C File Offset: 0x00276F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276899, XrefRangeEnd = 276918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectListFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C06 RID: 39942 RVA: 0x0004C70F File Offset: 0x0004A90F
		public ObjectListFieldUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003006 RID: 12294
		// (get) Token: 0x06009C07 RID: 39943 RVA: 0x00278D58 File Offset: 0x00276F58
		// (set) Token: 0x06009C08 RID: 39944 RVA: 0x0004C718 File Offset: 0x0004A918
		public unsafe List<ObjectListField> _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ObjectListField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003007 RID: 12295
		// (get) Token: 0x06009C09 RID: 39945 RVA: 0x00278D88 File Offset: 0x00276F88
		// (set) Token: 0x06009C0A RID: 39946 RVA: 0x0004C737 File Offset: 0x0004A937
		public unsafe string FieldText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_FieldText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_FieldText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003008 RID: 12296
		// (get) Token: 0x06009C0B RID: 39947 RVA: 0x00278DB0 File Offset: 0x00276FB0
		// (set) Token: 0x06009C0C RID: 39948 RVA: 0x0004C756 File Offset: 0x0004A956
		public unsafe string InstructionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_InstructionText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_InstructionText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003009 RID: 12297
		// (get) Token: 0x06009C0D RID: 39949 RVA: 0x00278DD8 File Offset: 0x00276FD8
		// (set) Token: 0x06009C0E RID: 39950 RVA: 0x0004C775 File Offset: 0x0004A975
		public unsafe string ExtendedInstructionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_ExtendedInstructionText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_ExtendedInstructionText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700300A RID: 12298
		// (get) Token: 0x06009C0F RID: 39951 RVA: 0x00278E00 File Offset: 0x00277000
		// (set) Token: 0x06009C10 RID: 39952 RVA: 0x0004C794 File Offset: 0x0004A994
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_FieldLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700300B RID: 12299
		// (get) Token: 0x06009C11 RID: 39953 RVA: 0x00278E30 File Offset: 0x00277030
		// (set) Token: 0x06009C12 RID: 39954 RVA: 0x0004C7B3 File Offset: 0x0004A9B3
		public unsafe GameObject NoneSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_NoneSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_NoneSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700300C RID: 12300
		// (get) Token: 0x06009C13 RID: 39955 RVA: 0x00278E60 File Offset: 0x00277060
		// (set) Token: 0x06009C14 RID: 39956 RVA: 0x0004C7D2 File Offset: 0x0004A9D2
		public unsafe GameObject MultipleSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_MultipleSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_MultipleSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700300D RID: 12301
		// (get) Token: 0x06009C15 RID: 39957 RVA: 0x00278E90 File Offset: 0x00277090
		// (set) Token: 0x06009C16 RID: 39958 RVA: 0x0004C7F1 File Offset: 0x0004A9F1
		public unsafe Il2CppReferenceArray<RectTransform> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700300E RID: 12302
		// (get) Token: 0x06009C17 RID: 39959 RVA: 0x00278EC0 File Offset: 0x002770C0
		// (set) Token: 0x06009C18 RID: 39960 RVA: 0x0004C810 File Offset: 0x0004AA10
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700300F RID: 12303
		// (get) Token: 0x06009C19 RID: 39961 RVA: 0x00278EF0 File Offset: 0x002770F0
		// (set) Token: 0x06009C1A RID: 39962 RVA: 0x0004C82F File Offset: 0x0004AA2F
		public unsafe GameObject EditIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_EditIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_EditIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003010 RID: 12304
		// (get) Token: 0x06009C1B RID: 39963 RVA: 0x00278F20 File Offset: 0x00277120
		// (set) Token: 0x06009C1C RID: 39964 RVA: 0x0004C84E File Offset: 0x0004AA4E
		public unsafe GameObject NoMultiEdit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_NoMultiEdit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_NoMultiEdit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040068CA RID: 26826
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x040068CB RID: 26827
		private static readonly IntPtr NativeFieldInfoPtr_FieldText;

		// Token: 0x040068CC RID: 26828
		private static readonly IntPtr NativeFieldInfoPtr_InstructionText;

		// Token: 0x040068CD RID: 26829
		private static readonly IntPtr NativeFieldInfoPtr_ExtendedInstructionText;

		// Token: 0x040068CE RID: 26830
		private static readonly IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x040068CF RID: 26831
		private static readonly IntPtr NativeFieldInfoPtr_NoneSelected;

		// Token: 0x040068D0 RID: 26832
		private static readonly IntPtr NativeFieldInfoPtr_MultipleSelected;

		// Token: 0x040068D1 RID: 26833
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x040068D2 RID: 26834
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x040068D3 RID: 26835
		private static readonly IntPtr NativeFieldInfoPtr_EditIcon;

		// Token: 0x040068D4 RID: 26836
		private static readonly IntPtr NativeFieldInfoPtr_NoMultiEdit;

		// Token: 0x040068D5 RID: 26837
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_ObjectListField_0;

		// Token: 0x040068D6 RID: 26838
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ObjectListField_0;

		// Token: 0x040068D7 RID: 26839
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_ObjectListField_0;

		// Token: 0x040068D8 RID: 26840
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_List_1_BuildableItem_0;

		// Token: 0x040068D9 RID: 26841
		private static readonly IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x040068DA RID: 26842
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x040068DB RID: 26843
		private static readonly IntPtr NativeMethodInfoPtr_ObjectValid_Private_Boolean_BuildableItem_byref_String_0;

		// Token: 0x040068DC RID: 26844
		private static readonly IntPtr NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_BuildableItem_0;

		// Token: 0x040068DD RID: 26845
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
