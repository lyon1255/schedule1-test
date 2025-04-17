using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200063D RID: 1597
	public class GenericSelectionModule : Singleton<GenericSelectionModule>
	{
		// Token: 0x06008D22 RID: 36130 RVA: 0x0024CAE8 File Offset: 0x0024ACE8
		// Note: this type is marked as 'beforefieldinit'.
		static GenericSelectionModule()
		{
			Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "GenericSelectionModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr);
			GenericSelectionModule.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "<isOpen>k__BackingField");
			GenericSelectionModule.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "canvas");
			GenericSelectionModule.NativeFieldInfoPtr_TitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "TitleText");
			GenericSelectionModule.NativeFieldInfoPtr_OptionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "OptionContainer");
			GenericSelectionModule.NativeFieldInfoPtr_CloseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "CloseButton");
			GenericSelectionModule.NativeFieldInfoPtr_ListOptionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "ListOptionPrefab");
			GenericSelectionModule.NativeFieldInfoPtr_OptionChosen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "OptionChosen");
			GenericSelectionModule.NativeFieldInfoPtr__ChosenOptionIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "<ChosenOptionIndex>k__BackingField");
			GenericSelectionModule.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100680839);
			GenericSelectionModule.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100680840);
			GenericSelectionModule.NativeMethodInfoPtr_get_ChosenOptionIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100680841);
			GenericSelectionModule.NativeMethodInfoPtr_set_ChosenOptionIndex_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100680842);
			GenericSelectionModule.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100680843);
			GenericSelectionModule.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100680844);
			GenericSelectionModule.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100680845);
			GenericSelectionModule.NativeMethodInfoPtr_Open_Public_Void_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100680846);
			GenericSelectionModule.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100680847);
			GenericSelectionModule.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100680848);
			GenericSelectionModule.NativeMethodInfoPtr_ClearOptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100680849);
			GenericSelectionModule.NativeMethodInfoPtr_ListOptionClicked_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100680850);
			GenericSelectionModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100680851);
		}

		// Token: 0x17002B17 RID: 11031
		// (get) Token: 0x06008D23 RID: 36131 RVA: 0x0024CCBC File Offset: 0x0024AEBC
		// (set) Token: 0x06008D24 RID: 36132 RVA: 0x0024CCF8 File Offset: 0x0024AEF8
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002B18 RID: 11032
		// (get) Token: 0x06008D25 RID: 36133 RVA: 0x0024CD38 File Offset: 0x0024AF38
		// (set) Token: 0x06008D26 RID: 36134 RVA: 0x0024CD74 File Offset: 0x0024AF74
		public unsafe int ChosenOptionIndex
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 69396, RefRangeEnd = 69397, XrefRangeStart = 69396, XrefRangeEnd = 69397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_get_ChosenOptionIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 257569, RefRangeEnd = 257578, XrefRangeStart = 257569, XrefRangeEnd = 257569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_set_ChosenOptionIndex_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008D27 RID: 36135 RVA: 0x0024CDB4 File Offset: 0x0024AFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257578, XrefRangeEnd = 257584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericSelectionModule.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D28 RID: 36136 RVA: 0x0024CDF0 File Offset: 0x0024AFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257584, XrefRangeEnd = 257597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericSelectionModule.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D29 RID: 36137 RVA: 0x0024CE2C File Offset: 0x0024B02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257597, XrefRangeEnd = 257599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D2A RID: 36138 RVA: 0x0024CE70 File Offset: 0x0024B070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257599, XrefRangeEnd = 257639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string title, List<string> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_Open_Public_Void_String_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D2B RID: 36139 RVA: 0x0024CEC4 File Offset: 0x0024B0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257639, XrefRangeEnd = 257642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D2C RID: 36140 RVA: 0x0024CEF8 File Offset: 0x0024B0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257642, XrefRangeEnd = 257645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D2D RID: 36141 RVA: 0x0024CF2C File Offset: 0x0024B12C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 257652, RefRangeEnd = 257659, XrefRangeStart = 257645, XrefRangeEnd = 257652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_ClearOptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D2E RID: 36142 RVA: 0x0024CF60 File Offset: 0x0024B160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257659, XrefRangeEnd = 257662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ListOptionClicked(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_ListOptionClicked_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D2F RID: 36143 RVA: 0x0024CFA0 File Offset: 0x0024B1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257662, XrefRangeEnd = 257665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericSelectionModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D30 RID: 36144 RVA: 0x00043B53 File Offset: 0x00041D53
		public GenericSelectionModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B0F RID: 11023
		// (get) Token: 0x06008D31 RID: 36145 RVA: 0x0024CFDC File Offset: 0x0024B1DC
		// (set) Token: 0x06008D32 RID: 36146 RVA: 0x00043B5C File Offset: 0x00041D5C
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002B10 RID: 11024
		// (get) Token: 0x06008D33 RID: 36147 RVA: 0x0024D004 File Offset: 0x0024B204
		// (set) Token: 0x06008D34 RID: 36148 RVA: 0x00043B77 File Offset: 0x00041D77
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B11 RID: 11025
		// (get) Token: 0x06008D35 RID: 36149 RVA: 0x0024D034 File Offset: 0x0024B234
		// (set) Token: 0x06008D36 RID: 36150 RVA: 0x00043B96 File Offset: 0x00041D96
		public unsafe TextMeshProUGUI TitleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_TitleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_TitleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B12 RID: 11026
		// (get) Token: 0x06008D37 RID: 36151 RVA: 0x0024D064 File Offset: 0x0024B264
		// (set) Token: 0x06008D38 RID: 36152 RVA: 0x00043BB5 File Offset: 0x00041DB5
		public unsafe RectTransform OptionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_OptionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_OptionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B13 RID: 11027
		// (get) Token: 0x06008D39 RID: 36153 RVA: 0x0024D094 File Offset: 0x0024B294
		// (set) Token: 0x06008D3A RID: 36154 RVA: 0x00043BD4 File Offset: 0x00041DD4
		public unsafe Button CloseButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_CloseButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_CloseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B14 RID: 11028
		// (get) Token: 0x06008D3B RID: 36155 RVA: 0x0024D0C4 File Offset: 0x0024B2C4
		// (set) Token: 0x06008D3C RID: 36156 RVA: 0x00043BF3 File Offset: 0x00041DF3
		public unsafe GameObject ListOptionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_ListOptionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_ListOptionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B15 RID: 11029
		// (get) Token: 0x06008D3D RID: 36157 RVA: 0x0024D0F4 File Offset: 0x0024B2F4
		// (set) Token: 0x06008D3E RID: 36158 RVA: 0x00043C12 File Offset: 0x00041E12
		public unsafe bool OptionChosen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_OptionChosen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_OptionChosen)) = value;
			}
		}

		// Token: 0x17002B16 RID: 11030
		// (get) Token: 0x06008D3F RID: 36159 RVA: 0x0024D11C File Offset: 0x0024B31C
		// (set) Token: 0x06008D40 RID: 36160 RVA: 0x00043C2D File Offset: 0x00041E2D
		public unsafe int _ChosenOptionIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr__ChosenOptionIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr__ChosenOptionIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x04005F9F RID: 24479
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04005FA0 RID: 24480
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04005FA1 RID: 24481
		private static readonly IntPtr NativeFieldInfoPtr_TitleText;

		// Token: 0x04005FA2 RID: 24482
		private static readonly IntPtr NativeFieldInfoPtr_OptionContainer;

		// Token: 0x04005FA3 RID: 24483
		private static readonly IntPtr NativeFieldInfoPtr_CloseButton;

		// Token: 0x04005FA4 RID: 24484
		private static readonly IntPtr NativeFieldInfoPtr_ListOptionPrefab;

		// Token: 0x04005FA5 RID: 24485
		private static readonly IntPtr NativeFieldInfoPtr_OptionChosen;

		// Token: 0x04005FA6 RID: 24486
		private static readonly IntPtr NativeFieldInfoPtr__ChosenOptionIndex_k__BackingField;

		// Token: 0x04005FA7 RID: 24487
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04005FA8 RID: 24488
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04005FA9 RID: 24489
		private static readonly IntPtr NativeMethodInfoPtr_get_ChosenOptionIndex_Public_get_Int32_0;

		// Token: 0x04005FAA RID: 24490
		private static readonly IntPtr NativeMethodInfoPtr_set_ChosenOptionIndex_Protected_set_Void_Int32_0;

		// Token: 0x04005FAB RID: 24491
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005FAC RID: 24492
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04005FAD RID: 24493
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04005FAE RID: 24494
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_String_List_1_String_0;

		// Token: 0x04005FAF RID: 24495
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04005FB0 RID: 24496
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		// Token: 0x04005FB1 RID: 24497
		private static readonly IntPtr NativeMethodInfoPtr_ClearOptions_Private_Void_0;

		// Token: 0x04005FB2 RID: 24498
		private static readonly IntPtr NativeMethodInfoPtr_ListOptionClicked_Private_Void_Int32_0;

		// Token: 0x04005FB3 RID: 24499
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B23 RID: 2851
		[ObfuscatedName("ScheduleOne.UI.GenericSelectionModule+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D77A RID: 55162 RVA: 0x00333AF4 File Offset: 0x00331CF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr);
				GenericSelectionModule.__c__DisplayClass17_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr, "index");
				GenericSelectionModule.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				GenericSelectionModule.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr, 100680852);
				GenericSelectionModule.__c__DisplayClass17_0.NativeMethodInfoPtr__Open_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr, 100680853);
			}

			// Token: 0x0600D77B RID: 55163 RVA: 0x00333B70 File Offset: 0x00331D70
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D77C RID: 55164 RVA: 0x00333BAC File Offset: 0x00331DAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257566, XrefRangeEnd = 257569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Open_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.__c__DisplayClass17_0.NativeMethodInfoPtr__Open_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D77D RID: 55165 RVA: 0x00068E91 File Offset: 0x00067091
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042C9 RID: 17097
			// (get) Token: 0x0600D77E RID: 55166 RVA: 0x00333BE0 File Offset: 0x00331DE0
			// (set) Token: 0x0600D77F RID: 55167 RVA: 0x00068E9A File Offset: 0x0006709A
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.__c__DisplayClass17_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.__c__DisplayClass17_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170042CA RID: 17098
			// (get) Token: 0x0600D780 RID: 55168 RVA: 0x00333C08 File Offset: 0x00331E08
			// (set) Token: 0x0600D781 RID: 55169 RVA: 0x00068EB5 File Offset: 0x000670B5
			public unsafe GenericSelectionModule __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericSelectionModule>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090DA RID: 37082
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x040090DB RID: 37083
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090DC RID: 37084
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040090DD RID: 37085
			private static readonly IntPtr NativeMethodInfoPtr__Open_b__0_Internal_Void_0;
		}
	}
}
