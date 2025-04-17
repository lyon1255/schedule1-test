using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCustomization
{
	// Token: 0x020006F7 RID: 1783
	public class CharacterCustomizationCategory : MonoBehaviour
	{
		// Token: 0x06009FD7 RID: 40919 RVA: 0x00284898 File Offset: 0x00282A98
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCustomizationCategory()
		{
			Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCustomization", "CharacterCustomizationCategory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr);
			CharacterCustomizationCategory.NativeFieldInfoPtr_CategoryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "CategoryName");
			CharacterCustomizationCategory.NativeFieldInfoPtr_TitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "TitleText");
			CharacterCustomizationCategory.NativeFieldInfoPtr_BackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "BackButton");
			CharacterCustomizationCategory.NativeFieldInfoPtr_ScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "ScrollRect");
			CharacterCustomizationCategory.NativeFieldInfoPtr_ui = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "ui");
			CharacterCustomizationCategory.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "options");
			CharacterCustomizationCategory.NativeFieldInfoPtr_onOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "onOpen");
			CharacterCustomizationCategory.NativeFieldInfoPtr_onClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "onClose");
			CharacterCustomizationCategory.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100682856);
			CharacterCustomizationCategory.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100682857);
			CharacterCustomizationCategory.NativeMethodInfoPtr_Back_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100682858);
			CharacterCustomizationCategory.NativeMethodInfoPtr_OptionSelected_Private_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100682859);
			CharacterCustomizationCategory.NativeMethodInfoPtr_OptionDeselected_Private_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100682860);
			CharacterCustomizationCategory.NativeMethodInfoPtr_OptionPurchased_Private_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100682861);
			CharacterCustomizationCategory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100682862);
		}

		// Token: 0x06009FD8 RID: 40920 RVA: 0x002849F4 File Offset: 0x00282BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281734, XrefRangeEnd = 281781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FD9 RID: 40921 RVA: 0x00284A28 File Offset: 0x00282C28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281794, RefRangeEnd = 281795, XrefRangeStart = 281781, XrefRangeEnd = 281794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FDA RID: 40922 RVA: 0x00284A5C File Offset: 0x00282C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281795, XrefRangeEnd = 281800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Back()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr_Back_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FDB RID: 40923 RVA: 0x00284A90 File Offset: 0x00282C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281800, XrefRangeEnd = 281806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionSelected(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr_OptionSelected_Private_Void_CharacterCustomizationOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FDC RID: 40924 RVA: 0x00284AD4 File Offset: 0x00282CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281806, XrefRangeEnd = 281807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionDeselected(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr_OptionDeselected_Private_Void_CharacterCustomizationOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FDD RID: 40925 RVA: 0x00284B18 File Offset: 0x00282D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281807, XrefRangeEnd = 281817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionPurchased(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr_OptionPurchased_Private_Void_CharacterCustomizationOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FDE RID: 40926 RVA: 0x00284B5C File Offset: 0x00282D5C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCustomizationCategory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FDF RID: 40927 RVA: 0x0004E8C9 File Offset: 0x0004CAC9
		public CharacterCustomizationCategory(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700313F RID: 12607
		// (get) Token: 0x06009FE0 RID: 40928 RVA: 0x00284B98 File Offset: 0x00282D98
		// (set) Token: 0x06009FE1 RID: 40929 RVA: 0x0004E8D2 File Offset: 0x0004CAD2
		public unsafe string CategoryName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_CategoryName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_CategoryName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003140 RID: 12608
		// (get) Token: 0x06009FE2 RID: 40930 RVA: 0x00284BC0 File Offset: 0x00282DC0
		// (set) Token: 0x06009FE3 RID: 40931 RVA: 0x0004E8F1 File Offset: 0x0004CAF1
		public unsafe TextMeshProUGUI TitleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_TitleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_TitleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003141 RID: 12609
		// (get) Token: 0x06009FE4 RID: 40932 RVA: 0x00284BF0 File Offset: 0x00282DF0
		// (set) Token: 0x06009FE5 RID: 40933 RVA: 0x0004E910 File Offset: 0x0004CB10
		public unsafe Button BackButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_BackButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_BackButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003142 RID: 12610
		// (get) Token: 0x06009FE6 RID: 40934 RVA: 0x00284C20 File Offset: 0x00282E20
		// (set) Token: 0x06009FE7 RID: 40935 RVA: 0x0004E92F File Offset: 0x0004CB2F
		public unsafe ScrollRect ScrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_ScrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_ScrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003143 RID: 12611
		// (get) Token: 0x06009FE8 RID: 40936 RVA: 0x00284C50 File Offset: 0x00282E50
		// (set) Token: 0x06009FE9 RID: 40937 RVA: 0x0004E94E File Offset: 0x0004CB4E
		public unsafe CharacterCustomizationUI ui
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_ui);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_ui), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003144 RID: 12612
		// (get) Token: 0x06009FEA RID: 40938 RVA: 0x00284C80 File Offset: 0x00282E80
		// (set) Token: 0x06009FEB RID: 40939 RVA: 0x0004E96D File Offset: 0x0004CB6D
		public unsafe Il2CppReferenceArray<CharacterCustomizationOption> options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CharacterCustomizationOption>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003145 RID: 12613
		// (get) Token: 0x06009FEC RID: 40940 RVA: 0x00284CB0 File Offset: 0x00282EB0
		// (set) Token: 0x06009FED RID: 40941 RVA: 0x0004E98C File Offset: 0x0004CB8C
		public unsafe UnityEvent onOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_onOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_onOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003146 RID: 12614
		// (get) Token: 0x06009FEE RID: 40942 RVA: 0x00284CE0 File Offset: 0x00282EE0
		// (set) Token: 0x06009FEF RID: 40943 RVA: 0x0004E9AB File Offset: 0x0004CBAB
		public unsafe UnityEvent onClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_onClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_onClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006B31 RID: 27441
		private static readonly IntPtr NativeFieldInfoPtr_CategoryName;

		// Token: 0x04006B32 RID: 27442
		private static readonly IntPtr NativeFieldInfoPtr_TitleText;

		// Token: 0x04006B33 RID: 27443
		private static readonly IntPtr NativeFieldInfoPtr_BackButton;

		// Token: 0x04006B34 RID: 27444
		private static readonly IntPtr NativeFieldInfoPtr_ScrollRect;

		// Token: 0x04006B35 RID: 27445
		private static readonly IntPtr NativeFieldInfoPtr_ui;

		// Token: 0x04006B36 RID: 27446
		private static readonly IntPtr NativeFieldInfoPtr_options;

		// Token: 0x04006B37 RID: 27447
		private static readonly IntPtr NativeFieldInfoPtr_onOpen;

		// Token: 0x04006B38 RID: 27448
		private static readonly IntPtr NativeFieldInfoPtr_onClose;

		// Token: 0x04006B39 RID: 27449
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006B3A RID: 27450
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04006B3B RID: 27451
		private static readonly IntPtr NativeMethodInfoPtr_Back_Public_Void_0;

		// Token: 0x04006B3C RID: 27452
		private static readonly IntPtr NativeMethodInfoPtr_OptionSelected_Private_Void_CharacterCustomizationOption_0;

		// Token: 0x04006B3D RID: 27453
		private static readonly IntPtr NativeMethodInfoPtr_OptionDeselected_Private_Void_CharacterCustomizationOption_0;

		// Token: 0x04006B3E RID: 27454
		private static readonly IntPtr NativeMethodInfoPtr_OptionPurchased_Private_Void_CharacterCustomizationOption_0;

		// Token: 0x04006B3F RID: 27455
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BA6 RID: 2982
		[ObfuscatedName("ScheduleOne.UI.CharacterCustomization.CharacterCustomizationCategory+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DCA6 RID: 56486 RVA: 0x00342700 File Offset: 0x00340900
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr);
				CharacterCustomizationCategory.__c__DisplayClass8_0.NativeFieldInfoPtr_option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr, "option");
				CharacterCustomizationCategory.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				CharacterCustomizationCategory.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr, 100682863);
				CharacterCustomizationCategory.__c__DisplayClass8_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr, 100682864);
				CharacterCustomizationCategory.__c__DisplayClass8_0.NativeMethodInfoPtr__Awake_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr, 100682865);
				CharacterCustomizationCategory.__c__DisplayClass8_0.NativeMethodInfoPtr__Awake_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr, 100682866);
			}

			// Token: 0x0600DCA7 RID: 56487 RVA: 0x003427A4 File Offset: 0x003409A4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCA8 RID: 56488 RVA: 0x003427E0 File Offset: 0x003409E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281717, XrefRangeEnd = 281723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.__c__DisplayClass8_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCA9 RID: 56489 RVA: 0x00342814 File Offset: 0x00340A14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281723, XrefRangeEnd = 281724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.__c__DisplayClass8_0.NativeMethodInfoPtr__Awake_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCAA RID: 56490 RVA: 0x00342848 File Offset: 0x00340A48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281724, XrefRangeEnd = 281734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.__c__DisplayClass8_0.NativeMethodInfoPtr__Awake_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCAB RID: 56491 RVA: 0x0006B86C File Offset: 0x00069A6C
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004465 RID: 17509
			// (get) Token: 0x0600DCAC RID: 56492 RVA: 0x0034287C File Offset: 0x00340A7C
			// (set) Token: 0x0600DCAD RID: 56493 RVA: 0x0006B875 File Offset: 0x00069A75
			public unsafe CharacterCustomizationOption option
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.__c__DisplayClass8_0.NativeFieldInfoPtr_option);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationOption>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.__c__DisplayClass8_0.NativeFieldInfoPtr_option), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004466 RID: 17510
			// (get) Token: 0x0600DCAE RID: 56494 RVA: 0x003428AC File Offset: 0x00340AAC
			// (set) Token: 0x0600DCAF RID: 56495 RVA: 0x0006B894 File Offset: 0x00069A94
			public unsafe CharacterCustomizationCategory __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationCategory>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040093E0 RID: 37856
			private static readonly IntPtr NativeFieldInfoPtr_option;

			// Token: 0x040093E1 RID: 37857
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040093E2 RID: 37858
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040093E3 RID: 37859
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;

			// Token: 0x040093E4 RID: 37860
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__1_Internal_Void_0;

			// Token: 0x040093E5 RID: 37861
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__2_Internal_Void_0;
		}
	}
}
