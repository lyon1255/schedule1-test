using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006C8 RID: 1736
	public class ObjectFieldUI : MonoBehaviour
	{
		// Token: 0x06009BDD RID: 39901 RVA: 0x002782F8 File Offset: 0x002764F8
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectFieldUI()
		{
			Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ObjectFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr);
			ObjectFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			ObjectFieldUI.NativeFieldInfoPtr_InstructionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, "InstructionText");
			ObjectFieldUI.NativeFieldInfoPtr_ExtendedInstructionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, "ExtendedInstructionText");
			ObjectFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, "FieldLabel");
			ObjectFieldUI.NativeFieldInfoPtr_IconImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, "IconImg");
			ObjectFieldUI.NativeFieldInfoPtr_SelectionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, "SelectionLabel");
			ObjectFieldUI.NativeFieldInfoPtr_NoneSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, "NoneSelected");
			ObjectFieldUI.NativeFieldInfoPtr_MultipleSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, "MultipleSelected");
			ObjectFieldUI.NativeFieldInfoPtr_ClearButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, "ClearButton");
			ObjectFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_ObjectField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, 100682439);
			ObjectFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ObjectField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, 100682440);
			ObjectFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_ObjectField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, 100682441);
			ObjectFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, 100682442);
			ObjectFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, 100682443);
			ObjectFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, 100682444);
			ObjectFieldUI.NativeMethodInfoPtr_ObjectValid_Private_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, 100682445);
			ObjectFieldUI.NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, 100682446);
			ObjectFieldUI.NativeMethodInfoPtr_ObjectSelected_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, 100682447);
			ObjectFieldUI.NativeMethodInfoPtr_ClearClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, 100682448);
			ObjectFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, 100682449);
		}

		// Token: 0x17003005 RID: 12293
		// (get) Token: 0x06009BDE RID: 39902 RVA: 0x002784B8 File Offset: 0x002766B8
		// (set) Token: 0x06009BDF RID: 39903 RVA: 0x002784F8 File Offset: 0x002766F8
		public unsafe List<ObjectField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_ObjectField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ObjectField>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ObjectField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009BE0 RID: 39904 RVA: 0x0027853C File Offset: 0x0027673C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 276530, RefRangeEnd = 276543, XrefRangeStart = 276503, XrefRangeEnd = 276530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<ObjectField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_ObjectField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BE1 RID: 39905 RVA: 0x00278580 File Offset: 0x00276780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276586, RefRangeEnd = 276587, XrefRangeStart = 276543, XrefRangeEnd = 276586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(BuildableItem newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BE2 RID: 39906 RVA: 0x002785C4 File Offset: 0x002767C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276598, RefRangeEnd = 276600, XrefRangeStart = 276587, XrefRangeEnd = 276598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009BE3 RID: 39907 RVA: 0x00278600 File Offset: 0x00276800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276600, XrefRangeEnd = 276657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BE4 RID: 39908 RVA: 0x00278634 File Offset: 0x00276834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276657, XrefRangeEnd = 276668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ObjectValid(BuildableItem obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectFieldUI.NativeMethodInfoPtr_ObjectValid_Private_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06009BE5 RID: 39909 RVA: 0x0027869C File Offset: 0x0027689C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276668, XrefRangeEnd = 276675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObjectsSelected(List<BuildableItem> objs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectFieldUI.NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BE6 RID: 39910 RVA: 0x002786E0 File Offset: 0x002768E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276699, RefRangeEnd = 276701, XrefRangeStart = 276675, XrefRangeEnd = 276699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObjectSelected(BuildableItem obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectFieldUI.NativeMethodInfoPtr_ObjectSelected_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BE7 RID: 39911 RVA: 0x00278724 File Offset: 0x00276924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276701, XrefRangeEnd = 276702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectFieldUI.NativeMethodInfoPtr_ClearClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BE8 RID: 39912 RVA: 0x00278758 File Offset: 0x00276958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276702, XrefRangeEnd = 276717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BE9 RID: 39913 RVA: 0x0004C5EF File Offset: 0x0004A7EF
		public ObjectFieldUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FFC RID: 12284
		// (get) Token: 0x06009BEA RID: 39914 RVA: 0x00278794 File Offset: 0x00276994
		// (set) Token: 0x06009BEB RID: 39915 RVA: 0x0004C5F8 File Offset: 0x0004A7F8
		public unsafe List<ObjectField> _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ObjectField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FFD RID: 12285
		// (get) Token: 0x06009BEC RID: 39916 RVA: 0x002787C4 File Offset: 0x002769C4
		// (set) Token: 0x06009BED RID: 39917 RVA: 0x0004C617 File Offset: 0x0004A817
		public unsafe string InstructionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_InstructionText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_InstructionText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002FFE RID: 12286
		// (get) Token: 0x06009BEE RID: 39918 RVA: 0x002787EC File Offset: 0x002769EC
		// (set) Token: 0x06009BEF RID: 39919 RVA: 0x0004C636 File Offset: 0x0004A836
		public unsafe string ExtendedInstructionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_ExtendedInstructionText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_ExtendedInstructionText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002FFF RID: 12287
		// (get) Token: 0x06009BF0 RID: 39920 RVA: 0x00278814 File Offset: 0x00276A14
		// (set) Token: 0x06009BF1 RID: 39921 RVA: 0x0004C655 File Offset: 0x0004A855
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_FieldLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003000 RID: 12288
		// (get) Token: 0x06009BF2 RID: 39922 RVA: 0x00278844 File Offset: 0x00276A44
		// (set) Token: 0x06009BF3 RID: 39923 RVA: 0x0004C674 File Offset: 0x0004A874
		public unsafe Image IconImg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_IconImg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_IconImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003001 RID: 12289
		// (get) Token: 0x06009BF4 RID: 39924 RVA: 0x00278874 File Offset: 0x00276A74
		// (set) Token: 0x06009BF5 RID: 39925 RVA: 0x0004C693 File Offset: 0x0004A893
		public unsafe TextMeshProUGUI SelectionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_SelectionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_SelectionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003002 RID: 12290
		// (get) Token: 0x06009BF6 RID: 39926 RVA: 0x002788A4 File Offset: 0x00276AA4
		// (set) Token: 0x06009BF7 RID: 39927 RVA: 0x0004C6B2 File Offset: 0x0004A8B2
		public unsafe GameObject NoneSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_NoneSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_NoneSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003003 RID: 12291
		// (get) Token: 0x06009BF8 RID: 39928 RVA: 0x002788D4 File Offset: 0x00276AD4
		// (set) Token: 0x06009BF9 RID: 39929 RVA: 0x0004C6D1 File Offset: 0x0004A8D1
		public unsafe GameObject MultipleSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_MultipleSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_MultipleSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003004 RID: 12292
		// (get) Token: 0x06009BFA RID: 39930 RVA: 0x00278904 File Offset: 0x00276B04
		// (set) Token: 0x06009BFB RID: 39931 RVA: 0x0004C6F0 File Offset: 0x0004A8F0
		public unsafe RectTransform ClearButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_ClearButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_ClearButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040068B6 RID: 26806
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x040068B7 RID: 26807
		private static readonly IntPtr NativeFieldInfoPtr_InstructionText;

		// Token: 0x040068B8 RID: 26808
		private static readonly IntPtr NativeFieldInfoPtr_ExtendedInstructionText;

		// Token: 0x040068B9 RID: 26809
		private static readonly IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x040068BA RID: 26810
		private static readonly IntPtr NativeFieldInfoPtr_IconImg;

		// Token: 0x040068BB RID: 26811
		private static readonly IntPtr NativeFieldInfoPtr_SelectionLabel;

		// Token: 0x040068BC RID: 26812
		private static readonly IntPtr NativeFieldInfoPtr_NoneSelected;

		// Token: 0x040068BD RID: 26813
		private static readonly IntPtr NativeFieldInfoPtr_MultipleSelected;

		// Token: 0x040068BE RID: 26814
		private static readonly IntPtr NativeFieldInfoPtr_ClearButton;

		// Token: 0x040068BF RID: 26815
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_ObjectField_0;

		// Token: 0x040068C0 RID: 26816
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ObjectField_0;

		// Token: 0x040068C1 RID: 26817
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_ObjectField_0;

		// Token: 0x040068C2 RID: 26818
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_BuildableItem_0;

		// Token: 0x040068C3 RID: 26819
		private static readonly IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x040068C4 RID: 26820
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x040068C5 RID: 26821
		private static readonly IntPtr NativeMethodInfoPtr_ObjectValid_Private_Boolean_BuildableItem_byref_String_0;

		// Token: 0x040068C6 RID: 26822
		private static readonly IntPtr NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_BuildableItem_0;

		// Token: 0x040068C7 RID: 26823
		private static readonly IntPtr NativeMethodInfoPtr_ObjectSelected_Private_Void_BuildableItem_0;

		// Token: 0x040068C8 RID: 26824
		private static readonly IntPtr NativeMethodInfoPtr_ClearClicked_Public_Void_0;

		// Token: 0x040068C9 RID: 26825
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B8C RID: 2956
		[ObfuscatedName("ScheduleOne.UI.Management.ObjectFieldUI+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DBD6 RID: 56278 RVA: 0x00340268 File Offset: 0x0033E468
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ObjectFieldUI.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectFieldUI.__c>.NativeClassPtr);
				ObjectFieldUI.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectFieldUI.__c>.NativeClassPtr, "<>9");
				ObjectFieldUI.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectFieldUI.__c>.NativeClassPtr, "<>9__13_0");
				ObjectFieldUI.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldUI.__c>.NativeClassPtr, 100682451);
				ObjectFieldUI.__c.NativeMethodInfoPtr__Refresh_b__13_0_Internal_Boolean_ObjectField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldUI.__c>.NativeClassPtr, 100682452);
			}

			// Token: 0x0600DBD7 RID: 56279 RVA: 0x003402E4 File Offset: 0x0033E4E4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectFieldUI.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectFieldUI.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBD8 RID: 56280 RVA: 0x00340320 File Offset: 0x0033E520
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276498, XrefRangeEnd = 276503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Refresh_b__13_0(ObjectField x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectFieldUI.__c.NativeMethodInfoPtr__Refresh_b__13_0_Internal_Boolean_ObjectField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DBD9 RID: 56281 RVA: 0x0006B1A5 File Offset: 0x000693A5
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700442A RID: 17450
			// (get) Token: 0x0600DBDA RID: 56282 RVA: 0x00340370 File Offset: 0x0033E570
			// (set) Token: 0x0600DBDB RID: 56283 RVA: 0x0006B1AE File Offset: 0x000693AE
			public unsafe static ObjectFieldUI.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ObjectFieldUI.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ObjectFieldUI.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700442B RID: 17451
			// (get) Token: 0x0600DBDC RID: 56284 RVA: 0x00340398 File Offset: 0x0033E598
			// (set) Token: 0x0600DBDD RID: 56285 RVA: 0x0006B1C0 File Offset: 0x000693C0
			public unsafe static Func<ObjectField, bool> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ObjectFieldUI.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ObjectField, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ObjectFieldUI.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009365 RID: 37733
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009366 RID: 37734
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04009367 RID: 37735
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009368 RID: 37736
			private static readonly IntPtr NativeMethodInfoPtr__Refresh_b__13_0_Internal_Boolean_ObjectField_0;
		}
	}
}
