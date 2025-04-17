using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Properties;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200064B RID: 1611
	public class NewMixScreen : Singleton<NewMixScreen>
	{
		// Token: 0x06008EE8 RID: 36584 RVA: 0x00251C40 File Offset: 0x0024FE40
		// Note: this type is marked as 'beforefieldinit'.
		static NewMixScreen()
		{
			Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "NewMixScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr);
			NewMixScreen.NativeFieldInfoPtr_MAX_PROPERTIES_DISPLAYED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "MAX_PROPERTIES_DISPLAYED");
			NewMixScreen.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "canvas");
			NewMixScreen.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "Container");
			NewMixScreen.NativeFieldInfoPtr_nameInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "nameInputField");
			NewMixScreen.NativeFieldInfoPtr_mixAlreadyExistsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "mixAlreadyExistsText");
			NewMixScreen.NativeFieldInfoPtr_editIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "editIcon");
			NewMixScreen.NativeFieldInfoPtr_randomizeNameButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "randomizeNameButton");
			NewMixScreen.NativeFieldInfoPtr_confirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "confirmButton");
			NewMixScreen.NativeFieldInfoPtr_PropertiesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "PropertiesLabel");
			NewMixScreen.NativeFieldInfoPtr_MarketValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "MarketValueLabel");
			NewMixScreen.NativeFieldInfoPtr_Sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "Sound");
			NewMixScreen.NativeFieldInfoPtr_attributeEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "attributeEntryPrefab");
			NewMixScreen.NativeFieldInfoPtr_name1Library = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "name1Library");
			NewMixScreen.NativeFieldInfoPtr_name2Library = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "name2Library");
			NewMixScreen.NativeFieldInfoPtr_onMixNamed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "onMixNamed");
			NewMixScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681032);
			NewMixScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681033);
			NewMixScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681034);
			NewMixScreen.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681035);
			NewMixScreen.NativeMethodInfoPtr_Open_Public_Void_List_1_Property_EDrugType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681036);
			NewMixScreen.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681037);
			NewMixScreen.NativeMethodInfoPtr_RandomizeButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681038);
			NewMixScreen.NativeMethodInfoPtr_ConfirmButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681039);
			NewMixScreen.NativeMethodInfoPtr_GenerateUniqueName_Public_String_Il2CppReferenceArray_1_Property_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681040);
			NewMixScreen.NativeMethodInfoPtr_RefreshNameButtons_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681041);
			NewMixScreen.NativeMethodInfoPtr_OnNameValueChanged_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681042);
			NewMixScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681043);
		}

		// Token: 0x17002BC0 RID: 11200
		// (get) Token: 0x06008EE9 RID: 36585 RVA: 0x00251E8C File Offset: 0x0025008C
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 259469, RefRangeEnd = 259470, XrefRangeStart = 259467, XrefRangeEnd = 259469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06008EEA RID: 36586 RVA: 0x00251EC8 File Offset: 0x002500C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259470, XrefRangeEnd = 259496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NewMixScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EEB RID: 36587 RVA: 0x00251F04 File Offset: 0x00250104
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EEC RID: 36588 RVA: 0x00251F48 File Offset: 0x00250148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259496, XrefRangeEnd = 259512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NewMixScreen.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EED RID: 36589 RVA: 0x00251F84 File Offset: 0x00250184
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 259569, RefRangeEnd = 259571, XrefRangeStart = 259512, XrefRangeEnd = 259569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(List<Property> properties, EDrugType drugType, float productMarketValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drugType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productMarketValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_Open_Public_Void_List_1_Property_EDrugType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EEE RID: 36590 RVA: 0x00251FE4 File Offset: 0x002501E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259581, RefRangeEnd = 259582, XrefRangeStart = 259571, XrefRangeEnd = 259581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EEF RID: 36591 RVA: 0x00252018 File Offset: 0x00250218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259582, XrefRangeEnd = 259585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_RandomizeButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EF0 RID: 36592 RVA: 0x0025204C File Offset: 0x0025024C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259585, XrefRangeEnd = 259597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_ConfirmButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EF1 RID: 36593 RVA: 0x00252080 File Offset: 0x00250280
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 259632, RefRangeEnd = 259638, XrefRangeStart = 259597, XrefRangeEnd = 259632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GenerateUniqueName(Il2CppReferenceArray<Property> properties = null, EDrugType drugType = EDrugType.Marijuana)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drugType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_GenerateUniqueName_Public_String_Il2CppReferenceArray_1_Property_EDrugType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06008EF2 RID: 36594 RVA: 0x002520D8 File Offset: 0x002502D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259638, XrefRangeEnd = 259648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshNameButtons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_RefreshNameButtons_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EF3 RID: 36595 RVA: 0x0025210C File Offset: 0x0025030C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259648, XrefRangeEnd = 259678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnNameValueChanged(string newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_OnNameValueChanged_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EF4 RID: 36596 RVA: 0x00252150 File Offset: 0x00250350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259678, XrefRangeEnd = 259693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewMixScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EF5 RID: 36597 RVA: 0x00044D38 File Offset: 0x00042F38
		public NewMixScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002BB1 RID: 11185
		// (get) Token: 0x06008EF6 RID: 36598 RVA: 0x0025218C File Offset: 0x0025038C
		// (set) Token: 0x06008EF7 RID: 36599 RVA: 0x00044D41 File Offset: 0x00042F41
		public unsafe static int MAX_PROPERTIES_DISPLAYED
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NewMixScreen.NativeFieldInfoPtr_MAX_PROPERTIES_DISPLAYED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NewMixScreen.NativeFieldInfoPtr_MAX_PROPERTIES_DISPLAYED, (void*)(&value));
			}
		}

		// Token: 0x17002BB2 RID: 11186
		// (get) Token: 0x06008EF8 RID: 36600 RVA: 0x002521A8 File Offset: 0x002503A8
		// (set) Token: 0x06008EF9 RID: 36601 RVA: 0x00044D4F File Offset: 0x00042F4F
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BB3 RID: 11187
		// (get) Token: 0x06008EFA RID: 36602 RVA: 0x002521D8 File Offset: 0x002503D8
		// (set) Token: 0x06008EFB RID: 36603 RVA: 0x00044D6E File Offset: 0x00042F6E
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BB4 RID: 11188
		// (get) Token: 0x06008EFC RID: 36604 RVA: 0x00252208 File Offset: 0x00250408
		// (set) Token: 0x06008EFD RID: 36605 RVA: 0x00044D8D File Offset: 0x00042F8D
		public unsafe TMP_InputField nameInputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_nameInputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_nameInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BB5 RID: 11189
		// (get) Token: 0x06008EFE RID: 36606 RVA: 0x00252238 File Offset: 0x00250438
		// (set) Token: 0x06008EFF RID: 36607 RVA: 0x00044DAC File Offset: 0x00042FAC
		public unsafe GameObject mixAlreadyExistsText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_mixAlreadyExistsText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_mixAlreadyExistsText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BB6 RID: 11190
		// (get) Token: 0x06008F00 RID: 36608 RVA: 0x00252268 File Offset: 0x00250468
		// (set) Token: 0x06008F01 RID: 36609 RVA: 0x00044DCB File Offset: 0x00042FCB
		public unsafe RectTransform editIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_editIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_editIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BB7 RID: 11191
		// (get) Token: 0x06008F02 RID: 36610 RVA: 0x00252298 File Offset: 0x00250498
		// (set) Token: 0x06008F03 RID: 36611 RVA: 0x00044DEA File Offset: 0x00042FEA
		public unsafe Button randomizeNameButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_randomizeNameButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_randomizeNameButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BB8 RID: 11192
		// (get) Token: 0x06008F04 RID: 36612 RVA: 0x002522C8 File Offset: 0x002504C8
		// (set) Token: 0x06008F05 RID: 36613 RVA: 0x00044E09 File Offset: 0x00043009
		public unsafe Button confirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_confirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_confirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BB9 RID: 11193
		// (get) Token: 0x06008F06 RID: 36614 RVA: 0x002522F8 File Offset: 0x002504F8
		// (set) Token: 0x06008F07 RID: 36615 RVA: 0x00044E28 File Offset: 0x00043028
		public unsafe TextMeshProUGUI PropertiesLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_PropertiesLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_PropertiesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BBA RID: 11194
		// (get) Token: 0x06008F08 RID: 36616 RVA: 0x00252328 File Offset: 0x00250528
		// (set) Token: 0x06008F09 RID: 36617 RVA: 0x00044E47 File Offset: 0x00043047
		public unsafe TextMeshProUGUI MarketValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_MarketValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_MarketValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BBB RID: 11195
		// (get) Token: 0x06008F0A RID: 36618 RVA: 0x00252358 File Offset: 0x00250558
		// (set) Token: 0x06008F0B RID: 36619 RVA: 0x00044E66 File Offset: 0x00043066
		public unsafe AudioSourceController Sound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_Sound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_Sound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BBC RID: 11196
		// (get) Token: 0x06008F0C RID: 36620 RVA: 0x00252388 File Offset: 0x00250588
		// (set) Token: 0x06008F0D RID: 36621 RVA: 0x00044E85 File Offset: 0x00043085
		public unsafe GameObject attributeEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_attributeEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_attributeEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BBD RID: 11197
		// (get) Token: 0x06008F0E RID: 36622 RVA: 0x002523B8 File Offset: 0x002505B8
		// (set) Token: 0x06008F0F RID: 36623 RVA: 0x00044EA4 File Offset: 0x000430A4
		public unsafe List<string> name1Library
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_name1Library);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_name1Library), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BBE RID: 11198
		// (get) Token: 0x06008F10 RID: 36624 RVA: 0x002523E8 File Offset: 0x002505E8
		// (set) Token: 0x06008F11 RID: 36625 RVA: 0x00044EC3 File Offset: 0x000430C3
		public unsafe List<string> name2Library
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_name2Library);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_name2Library), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BBF RID: 11199
		// (get) Token: 0x06008F12 RID: 36626 RVA: 0x00252418 File Offset: 0x00250618
		// (set) Token: 0x06008F13 RID: 36627 RVA: 0x00044EE2 File Offset: 0x000430E2
		public unsafe Action<string> onMixNamed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_onMixNamed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_onMixNamed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040060B5 RID: 24757
		private static readonly IntPtr NativeFieldInfoPtr_MAX_PROPERTIES_DISPLAYED;

		// Token: 0x040060B6 RID: 24758
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x040060B7 RID: 24759
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040060B8 RID: 24760
		private static readonly IntPtr NativeFieldInfoPtr_nameInputField;

		// Token: 0x040060B9 RID: 24761
		private static readonly IntPtr NativeFieldInfoPtr_mixAlreadyExistsText;

		// Token: 0x040060BA RID: 24762
		private static readonly IntPtr NativeFieldInfoPtr_editIcon;

		// Token: 0x040060BB RID: 24763
		private static readonly IntPtr NativeFieldInfoPtr_randomizeNameButton;

		// Token: 0x040060BC RID: 24764
		private static readonly IntPtr NativeFieldInfoPtr_confirmButton;

		// Token: 0x040060BD RID: 24765
		private static readonly IntPtr NativeFieldInfoPtr_PropertiesLabel;

		// Token: 0x040060BE RID: 24766
		private static readonly IntPtr NativeFieldInfoPtr_MarketValueLabel;

		// Token: 0x040060BF RID: 24767
		private static readonly IntPtr NativeFieldInfoPtr_Sound;

		// Token: 0x040060C0 RID: 24768
		private static readonly IntPtr NativeFieldInfoPtr_attributeEntryPrefab;

		// Token: 0x040060C1 RID: 24769
		private static readonly IntPtr NativeFieldInfoPtr_name1Library;

		// Token: 0x040060C2 RID: 24770
		private static readonly IntPtr NativeFieldInfoPtr_name2Library;

		// Token: 0x040060C3 RID: 24771
		private static readonly IntPtr NativeFieldInfoPtr_onMixNamed;

		// Token: 0x040060C4 RID: 24772
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040060C5 RID: 24773
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040060C6 RID: 24774
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040060C7 RID: 24775
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040060C8 RID: 24776
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_List_1_Property_EDrugType_Single_0;

		// Token: 0x040060C9 RID: 24777
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040060CA RID: 24778
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeButtonClicked_Public_Void_0;

		// Token: 0x040060CB RID: 24779
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmButtonClicked_Public_Void_0;

		// Token: 0x040060CC RID: 24780
		private static readonly IntPtr NativeMethodInfoPtr_GenerateUniqueName_Public_String_Il2CppReferenceArray_1_Property_EDrugType_0;

		// Token: 0x040060CD RID: 24781
		private static readonly IntPtr NativeMethodInfoPtr_RefreshNameButtons_Protected_Void_0;

		// Token: 0x040060CE RID: 24782
		private static readonly IntPtr NativeMethodInfoPtr_OnNameValueChanged_Public_Void_String_0;

		// Token: 0x040060CF RID: 24783
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
