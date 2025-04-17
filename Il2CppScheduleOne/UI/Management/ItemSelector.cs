using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006CE RID: 1742
	public class ItemSelector : ClipboardScreen
	{
		// Token: 0x06009C74 RID: 40052 RVA: 0x0027A180 File Offset: 0x00278380
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSelector()
		{
			Il2CppClassPointerStore<ItemSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ItemSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr);
			ItemSelector.NativeFieldInfoPtr_OptionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "OptionContainer");
			ItemSelector.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "TitleLabel");
			ItemSelector.NativeFieldInfoPtr_HoveredItemLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "HoveredItemLabel");
			ItemSelector.NativeFieldInfoPtr_OptionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "OptionPrefab");
			ItemSelector.NativeFieldInfoPtr_EmptyOptionSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "EmptyOptionSprite");
			ItemSelector.NativeFieldInfoPtr_lerpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "lerpRoutine");
			ItemSelector.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "options");
			ItemSelector.NativeFieldInfoPtr_selectedOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "selectedOption");
			ItemSelector.NativeFieldInfoPtr_optionButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "optionButtons");
			ItemSelector.NativeFieldInfoPtr_optionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "optionCallback");
			ItemSelector.NativeMethodInfoPtr_Initialize_Public_Void_String_List_1_Option_Option_Action_1_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682506);
			ItemSelector.NativeMethodInfoPtr_Open_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682507);
			ItemSelector.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682508);
			ItemSelector.NativeMethodInfoPtr_ButtonClicked_Private_Void_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682509);
			ItemSelector.NativeMethodInfoPtr_ButtonHovered_Private_Void_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682510);
			ItemSelector.NativeMethodInfoPtr_ButtonHoverEnd_Private_Void_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682511);
			ItemSelector.NativeMethodInfoPtr_CreateOptions_Private_Void_List_1_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682512);
			ItemSelector.NativeMethodInfoPtr_DeleteOptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682513);
			ItemSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682514);
		}

		// Token: 0x06009C75 RID: 40053 RVA: 0x0027A32C File Offset: 0x0027852C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277536, RefRangeEnd = 277537, XrefRangeStart = 277509, XrefRangeEnd = 277536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(string selectionTitle, List<ItemSelector.Option> _options, ItemSelector.Option _selectedOption = null, Action<ItemSelector.Option> _optionCallback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(selectionTitle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_options);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_selectedOption);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_optionCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.NativeMethodInfoPtr_Initialize_Public_Void_String_List_1_Option_Option_Action_1_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C76 RID: 40054 RVA: 0x0027A3A8 File Offset: 0x002785A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277537, XrefRangeEnd = 277543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSelector.NativeMethodInfoPtr_Open_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C77 RID: 40055 RVA: 0x0027A3E4 File Offset: 0x002785E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277543, XrefRangeEnd = 277550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSelector.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C78 RID: 40056 RVA: 0x0027A420 File Offset: 0x00278620
		[CallerCount(0)]
		public unsafe void ButtonClicked(ItemSelector.Option option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.NativeMethodInfoPtr_ButtonClicked_Private_Void_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C79 RID: 40057 RVA: 0x0027A464 File Offset: 0x00278664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277550, XrefRangeEnd = 277562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ButtonHovered(ItemSelector.Option option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.NativeMethodInfoPtr_ButtonHovered_Private_Void_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C7A RID: 40058 RVA: 0x0027A4A8 File Offset: 0x002786A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277562, XrefRangeEnd = 277564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ButtonHoverEnd(ItemSelector.Option option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.NativeMethodInfoPtr_ButtonHoverEnd_Private_Void_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C7B RID: 40059 RVA: 0x0027A4EC File Offset: 0x002786EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277676, RefRangeEnd = 277677, XrefRangeStart = 277564, XrefRangeEnd = 277676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateOptions(List<ItemSelector.Option> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.NativeMethodInfoPtr_CreateOptions_Private_Void_List_1_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C7C RID: 40060 RVA: 0x0027A530 File Offset: 0x00278730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277677, XrefRangeEnd = 277689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.NativeMethodInfoPtr_DeleteOptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C7D RID: 40061 RVA: 0x0027A564 File Offset: 0x00278764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277689, XrefRangeEnd = 277704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C7E RID: 40062 RVA: 0x0004CB14 File Offset: 0x0004AD14
		public ItemSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700302B RID: 12331
		// (get) Token: 0x06009C7F RID: 40063 RVA: 0x0027A5A0 File Offset: 0x002787A0
		// (set) Token: 0x06009C80 RID: 40064 RVA: 0x0004CB1D File Offset: 0x0004AD1D
		public unsafe RectTransform OptionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_OptionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_OptionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700302C RID: 12332
		// (get) Token: 0x06009C81 RID: 40065 RVA: 0x0027A5D0 File Offset: 0x002787D0
		// (set) Token: 0x06009C82 RID: 40066 RVA: 0x0004CB3C File Offset: 0x0004AD3C
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700302D RID: 12333
		// (get) Token: 0x06009C83 RID: 40067 RVA: 0x0027A600 File Offset: 0x00278800
		// (set) Token: 0x06009C84 RID: 40068 RVA: 0x0004CB5B File Offset: 0x0004AD5B
		public unsafe TextMeshProUGUI HoveredItemLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_HoveredItemLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_HoveredItemLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700302E RID: 12334
		// (get) Token: 0x06009C85 RID: 40069 RVA: 0x0027A630 File Offset: 0x00278830
		// (set) Token: 0x06009C86 RID: 40070 RVA: 0x0004CB7A File Offset: 0x0004AD7A
		public unsafe GameObject OptionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_OptionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_OptionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700302F RID: 12335
		// (get) Token: 0x06009C87 RID: 40071 RVA: 0x0027A660 File Offset: 0x00278860
		// (set) Token: 0x06009C88 RID: 40072 RVA: 0x0004CB99 File Offset: 0x0004AD99
		public unsafe Sprite EmptyOptionSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_EmptyOptionSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_EmptyOptionSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003030 RID: 12336
		// (get) Token: 0x06009C89 RID: 40073 RVA: 0x0027A690 File Offset: 0x00278890
		// (set) Token: 0x06009C8A RID: 40074 RVA: 0x0004CBB8 File Offset: 0x0004ADB8
		public new unsafe Coroutine lerpRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_lerpRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_lerpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003031 RID: 12337
		// (get) Token: 0x06009C8B RID: 40075 RVA: 0x0027A6C0 File Offset: 0x002788C0
		// (set) Token: 0x06009C8C RID: 40076 RVA: 0x0004CBD7 File Offset: 0x0004ADD7
		public unsafe List<ItemSelector.Option> options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSelector.Option>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003032 RID: 12338
		// (get) Token: 0x06009C8D RID: 40077 RVA: 0x0027A6F0 File Offset: 0x002788F0
		// (set) Token: 0x06009C8E RID: 40078 RVA: 0x0004CBF6 File Offset: 0x0004ADF6
		public unsafe ItemSelector.Option selectedOption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_selectedOption);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSelector.Option>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_selectedOption), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003033 RID: 12339
		// (get) Token: 0x06009C8F RID: 40079 RVA: 0x0027A720 File Offset: 0x00278920
		// (set) Token: 0x06009C90 RID: 40080 RVA: 0x0004CC15 File Offset: 0x0004AE15
		public unsafe List<RectTransform> optionButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_optionButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_optionButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003034 RID: 12340
		// (get) Token: 0x06009C91 RID: 40081 RVA: 0x0027A750 File Offset: 0x00278950
		// (set) Token: 0x06009C92 RID: 40082 RVA: 0x0004CC34 File Offset: 0x0004AE34
		public unsafe Action<ItemSelector.Option> optionCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_optionCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ItemSelector.Option>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_optionCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006918 RID: 26904
		private static readonly IntPtr NativeFieldInfoPtr_OptionContainer;

		// Token: 0x04006919 RID: 26905
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x0400691A RID: 26906
		private static readonly IntPtr NativeFieldInfoPtr_HoveredItemLabel;

		// Token: 0x0400691B RID: 26907
		private static readonly IntPtr NativeFieldInfoPtr_OptionPrefab;

		// Token: 0x0400691C RID: 26908
		private static readonly IntPtr NativeFieldInfoPtr_EmptyOptionSprite;

		// Token: 0x0400691D RID: 26909
		private static readonly IntPtr NativeFieldInfoPtr_lerpRoutine;

		// Token: 0x0400691E RID: 26910
		private static readonly IntPtr NativeFieldInfoPtr_options;

		// Token: 0x0400691F RID: 26911
		private static readonly IntPtr NativeFieldInfoPtr_selectedOption;

		// Token: 0x04006920 RID: 26912
		private static readonly IntPtr NativeFieldInfoPtr_optionButtons;

		// Token: 0x04006921 RID: 26913
		private static readonly IntPtr NativeFieldInfoPtr_optionCallback;

		// Token: 0x04006922 RID: 26914
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_String_List_1_Option_Option_Action_1_Option_0;

		// Token: 0x04006923 RID: 26915
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_0;

		// Token: 0x04006924 RID: 26916
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04006925 RID: 26917
		private static readonly IntPtr NativeMethodInfoPtr_ButtonClicked_Private_Void_Option_0;

		// Token: 0x04006926 RID: 26918
		private static readonly IntPtr NativeMethodInfoPtr_ButtonHovered_Private_Void_Option_0;

		// Token: 0x04006927 RID: 26919
		private static readonly IntPtr NativeMethodInfoPtr_ButtonHoverEnd_Private_Void_Option_0;

		// Token: 0x04006928 RID: 26920
		private static readonly IntPtr NativeMethodInfoPtr_CreateOptions_Private_Void_List_1_Option_0;

		// Token: 0x04006929 RID: 26921
		private static readonly IntPtr NativeMethodInfoPtr_DeleteOptions_Private_Void_0;

		// Token: 0x0400692A RID: 26922
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B90 RID: 2960
		[Serializable]
		public class Option : Il2CppSystem.Object
		{
			// Token: 0x0600DBF6 RID: 56310 RVA: 0x003407A8 File Offset: 0x0033E9A8
			// Note: this type is marked as 'beforefieldinit'.
			static Option()
			{
				Il2CppClassPointerStore<ItemSelector.Option>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "Option");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSelector.Option>.NativeClassPtr);
				ItemSelector.Option.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector.Option>.NativeClassPtr, "Title");
				ItemSelector.Option.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector.Option>.NativeClassPtr, "Item");
				ItemSelector.Option.NativeMethodInfoPtr__ctor_Public_Void_String_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector.Option>.NativeClassPtr, 100682515);
			}

			// Token: 0x0600DBF7 RID: 56311 RVA: 0x00340810 File Offset: 0x0033EA10
			[CallerCount(49)]
			[CachedScanResults(RefRangeStart = 110661, RefRangeEnd = 110710, XrefRangeStart = 110661, XrefRangeEnd = 110710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Option(string title, ItemDefinition item) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSelector.Option>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.Option.NativeMethodInfoPtr__ctor_Public_Void_String_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBF8 RID: 56312 RVA: 0x0006B289 File Offset: 0x00069489
			public Option(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004432 RID: 17458
			// (get) Token: 0x0600DBF9 RID: 56313 RVA: 0x00340870 File Offset: 0x0033EA70
			// (set) Token: 0x0600DBFA RID: 56314 RVA: 0x0006B292 File Offset: 0x00069492
			public unsafe string Title
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.Option.NativeFieldInfoPtr_Title);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.Option.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004433 RID: 17459
			// (get) Token: 0x0600DBFB RID: 56315 RVA: 0x00340898 File Offset: 0x0033EA98
			// (set) Token: 0x0600DBFC RID: 56316 RVA: 0x0006B2B1 File Offset: 0x000694B1
			public unsafe ItemDefinition Item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.Option.NativeFieldInfoPtr_Item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.Option.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009375 RID: 37749
			private static readonly IntPtr NativeFieldInfoPtr_Title;

			// Token: 0x04009376 RID: 37750
			private static readonly IntPtr NativeFieldInfoPtr_Item;

			// Token: 0x04009377 RID: 37751
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ItemDefinition_0;
		}

		// Token: 0x02000B91 RID: 2961
		[ObfuscatedName("ScheduleOne.UI.Management.ItemSelector+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DBFD RID: 56317 RVA: 0x003408C8 File Offset: 0x0033EAC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr);
				ItemSelector.__c__DisplayClass17_0.NativeFieldInfoPtr_opt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr, "opt");
				ItemSelector.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				ItemSelector.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr, 100682516);
				ItemSelector.__c__DisplayClass17_0.NativeMethodInfoPtr__CreateOptions_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr, 100682517);
				ItemSelector.__c__DisplayClass17_0.NativeMethodInfoPtr__CreateOptions_b__1_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr, 100682518);
				ItemSelector.__c__DisplayClass17_0.NativeMethodInfoPtr__CreateOptions_b__2_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr, 100682519);
			}

			// Token: 0x0600DBFE RID: 56318 RVA: 0x0034096C File Offset: 0x0033EB6C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBFF RID: 56319 RVA: 0x003409A8 File Offset: 0x0033EBA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277494, XrefRangeEnd = 277495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateOptions_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.__c__DisplayClass17_0.NativeMethodInfoPtr__CreateOptions_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC00 RID: 56320 RVA: 0x003409DC File Offset: 0x0033EBDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277495, XrefRangeEnd = 277507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateOptions_b__1(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.__c__DisplayClass17_0.NativeMethodInfoPtr__CreateOptions_b__1_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC01 RID: 56321 RVA: 0x00340A20 File Offset: 0x0033EC20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277507, XrefRangeEnd = 277509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateOptions_b__2(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.__c__DisplayClass17_0.NativeMethodInfoPtr__CreateOptions_b__2_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC02 RID: 56322 RVA: 0x0006B2D0 File Offset: 0x000694D0
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004434 RID: 17460
			// (get) Token: 0x0600DC03 RID: 56323 RVA: 0x00340A64 File Offset: 0x0033EC64
			// (set) Token: 0x0600DC04 RID: 56324 RVA: 0x0006B2D9 File Offset: 0x000694D9
			public unsafe ItemSelector.Option opt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.__c__DisplayClass17_0.NativeFieldInfoPtr_opt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSelector.Option>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.__c__DisplayClass17_0.NativeFieldInfoPtr_opt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004435 RID: 17461
			// (get) Token: 0x0600DC05 RID: 56325 RVA: 0x00340A94 File Offset: 0x0033EC94
			// (set) Token: 0x0600DC06 RID: 56326 RVA: 0x0006B2F8 File Offset: 0x000694F8
			public unsafe ItemSelector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSelector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009378 RID: 37752
			private static readonly IntPtr NativeFieldInfoPtr_opt;

			// Token: 0x04009379 RID: 37753
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400937A RID: 37754
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400937B RID: 37755
			private static readonly IntPtr NativeMethodInfoPtr__CreateOptions_b__0_Internal_Void_0;

			// Token: 0x0400937C RID: 37756
			private static readonly IntPtr NativeMethodInfoPtr__CreateOptions_b__1_Internal_Void_BaseEventData_0;

			// Token: 0x0400937D RID: 37757
			private static readonly IntPtr NativeMethodInfoPtr__CreateOptions_b__2_Internal_Void_BaseEventData_0;
		}
	}
}
