using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCreator
{
	// Token: 0x020006FF RID: 1791
	public class CharacterCreatorOptionList : CharacterCreatorField<string>
	{
		// Token: 0x0600A0A8 RID: 41128 RVA: 0x00287110 File Offset: 0x00285310
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCreatorOptionList()
		{
			Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCreator", "CharacterCreatorOptionList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr);
			CharacterCreatorOptionList.NativeFieldInfoPtr_OptionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "OptionContainer");
			CharacterCreatorOptionList.NativeFieldInfoPtr_CanSelectNone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "CanSelectNone");
			CharacterCreatorOptionList.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "Options");
			CharacterCreatorOptionList.NativeFieldInfoPtr_OptionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "OptionPrefab");
			CharacterCreatorOptionList.NativeFieldInfoPtr_optionButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "optionButtons");
			CharacterCreatorOptionList.NativeFieldInfoPtr_selectedButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "selectedButton");
			CharacterCreatorOptionList.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, 100682947);
			CharacterCreatorOptionList.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, 100682948);
			CharacterCreatorOptionList.NativeMethodInfoPtr_OptionClicked_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, 100682949);
			CharacterCreatorOptionList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, 100682950);
		}

		// Token: 0x0600A0A9 RID: 41129 RVA: 0x00287208 File Offset: 0x00285408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282428, XrefRangeEnd = 282486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorOptionList.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0AA RID: 41130 RVA: 0x00287244 File Offset: 0x00285444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282486, XrefRangeEnd = 282513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorOptionList.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0AB RID: 41131 RVA: 0x00287280 File Offset: 0x00285480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282513, XrefRangeEnd = 282532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionClicked(string option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.NativeMethodInfoPtr_OptionClicked_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0AC RID: 41132 RVA: 0x002872C4 File Offset: 0x002854C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282532, XrefRangeEnd = 282542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCreatorOptionList() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0AD RID: 41133 RVA: 0x0004F05A File Offset: 0x0004D25A
		public CharacterCreatorOptionList(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003183 RID: 12675
		// (get) Token: 0x0600A0AE RID: 41134 RVA: 0x00287300 File Offset: 0x00285500
		// (set) Token: 0x0600A0AF RID: 41135 RVA: 0x0004F063 File Offset: 0x0004D263
		public unsafe RectTransform OptionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_OptionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_OptionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003184 RID: 12676
		// (get) Token: 0x0600A0B0 RID: 41136 RVA: 0x00287330 File Offset: 0x00285530
		// (set) Token: 0x0600A0B1 RID: 41137 RVA: 0x0004F082 File Offset: 0x0004D282
		public unsafe bool CanSelectNone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_CanSelectNone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_CanSelectNone)) = value;
			}
		}

		// Token: 0x17003185 RID: 12677
		// (get) Token: 0x0600A0B2 RID: 41138 RVA: 0x00287358 File Offset: 0x00285558
		// (set) Token: 0x0600A0B3 RID: 41139 RVA: 0x0004F09D File Offset: 0x0004D29D
		public unsafe List<CharacterCreatorOptionList.Option> Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CharacterCreatorOptionList.Option>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003186 RID: 12678
		// (get) Token: 0x0600A0B4 RID: 41140 RVA: 0x00287388 File Offset: 0x00285588
		// (set) Token: 0x0600A0B5 RID: 41141 RVA: 0x0004F0BC File Offset: 0x0004D2BC
		public unsafe GameObject OptionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_OptionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_OptionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003187 RID: 12679
		// (get) Token: 0x0600A0B6 RID: 41142 RVA: 0x002873B8 File Offset: 0x002855B8
		// (set) Token: 0x0600A0B7 RID: 41143 RVA: 0x0004F0DB File Offset: 0x0004D2DB
		public unsafe List<Button> optionButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_optionButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_optionButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003188 RID: 12680
		// (get) Token: 0x0600A0B8 RID: 41144 RVA: 0x002873E8 File Offset: 0x002855E8
		// (set) Token: 0x0600A0B9 RID: 41145 RVA: 0x0004F0FA File Offset: 0x0004D2FA
		public unsafe Button selectedButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_selectedButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_selectedButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006BB3 RID: 27571
		private static readonly IntPtr NativeFieldInfoPtr_OptionContainer;

		// Token: 0x04006BB4 RID: 27572
		private static readonly IntPtr NativeFieldInfoPtr_CanSelectNone;

		// Token: 0x04006BB5 RID: 27573
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x04006BB6 RID: 27574
		private static readonly IntPtr NativeFieldInfoPtr_OptionPrefab;

		// Token: 0x04006BB7 RID: 27575
		private static readonly IntPtr NativeFieldInfoPtr_optionButtons;

		// Token: 0x04006BB8 RID: 27576
		private static readonly IntPtr NativeFieldInfoPtr_selectedButton;

		// Token: 0x04006BB9 RID: 27577
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006BBA RID: 27578
		private static readonly IntPtr NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0;

		// Token: 0x04006BBB RID: 27579
		private static readonly IntPtr NativeMethodInfoPtr_OptionClicked_Public_Void_String_0;

		// Token: 0x04006BBC RID: 27580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BAC RID: 2988
		[Serializable]
		public class Option : Il2CppSystem.Object
		{
			// Token: 0x0600DCE5 RID: 56549 RVA: 0x003432A0 File Offset: 0x003414A0
			// Note: this type is marked as 'beforefieldinit'.
			static Option()
			{
				Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "Option");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr);
				CharacterCreatorOptionList.Option.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr, "Label");
				CharacterCreatorOptionList.Option.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr, "AssetPath");
				CharacterCreatorOptionList.Option.NativeFieldInfoPtr_ClothingItemEquivalent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr, "ClothingItemEquivalent");
				CharacterCreatorOptionList.Option.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr, 100682951);
			}

			// Token: 0x0600DCE6 RID: 56550 RVA: 0x0034331C File Offset: 0x0034151C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Option() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.Option.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCE7 RID: 56551 RVA: 0x0006BA48 File Offset: 0x00069C48
			public Option(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004477 RID: 17527
			// (get) Token: 0x0600DCE8 RID: 56552 RVA: 0x00343358 File Offset: 0x00341558
			// (set) Token: 0x0600DCE9 RID: 56553 RVA: 0x0006BA51 File Offset: 0x00069C51
			public unsafe string Label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.Option.NativeFieldInfoPtr_Label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.Option.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004478 RID: 17528
			// (get) Token: 0x0600DCEA RID: 56554 RVA: 0x00343380 File Offset: 0x00341580
			// (set) Token: 0x0600DCEB RID: 56555 RVA: 0x0006BA70 File Offset: 0x00069C70
			public unsafe string AssetPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.Option.NativeFieldInfoPtr_AssetPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.Option.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004479 RID: 17529
			// (get) Token: 0x0600DCEC RID: 56556 RVA: 0x003433A8 File Offset: 0x003415A8
			// (set) Token: 0x0600DCED RID: 56557 RVA: 0x0006BA8F File Offset: 0x00069C8F
			public unsafe ClothingDefinition ClothingItemEquivalent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.Option.NativeFieldInfoPtr_ClothingItemEquivalent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClothingDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.Option.NativeFieldInfoPtr_ClothingItemEquivalent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009405 RID: 37893
			private static readonly IntPtr NativeFieldInfoPtr_Label;

			// Token: 0x04009406 RID: 37894
			private static readonly IntPtr NativeFieldInfoPtr_AssetPath;

			// Token: 0x04009407 RID: 37895
			private static readonly IntPtr NativeFieldInfoPtr_ClothingItemEquivalent;

			// Token: 0x04009408 RID: 37896
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BAD RID: 2989
		[ObfuscatedName("ScheduleOne.UI.CharacterCreator.CharacterCreatorOptionList+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DCEE RID: 56558 RVA: 0x003433D8 File Offset: 0x003415D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr);
				CharacterCreatorOptionList.__c__DisplayClass7_0.NativeFieldInfoPtr_option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr, "option");
				CharacterCreatorOptionList.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				CharacterCreatorOptionList.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr, 100682952);
				CharacterCreatorOptionList.__c__DisplayClass7_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr, 100682953);
			}

			// Token: 0x0600DCEF RID: 56559 RVA: 0x00343454 File Offset: 0x00341654
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCF0 RID: 56560 RVA: 0x00343490 File Offset: 0x00341690
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282409, XrefRangeEnd = 282428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.__c__DisplayClass7_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCF1 RID: 56561 RVA: 0x0006BAAE File Offset: 0x00069CAE
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700447A RID: 17530
			// (get) Token: 0x0600DCF2 RID: 56562 RVA: 0x003434C4 File Offset: 0x003416C4
			// (set) Token: 0x0600DCF3 RID: 56563 RVA: 0x0006BAB7 File Offset: 0x00069CB7
			public unsafe string option
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.__c__DisplayClass7_0.NativeFieldInfoPtr_option);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.__c__DisplayClass7_0.NativeFieldInfoPtr_option), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700447B RID: 17531
			// (get) Token: 0x0600DCF4 RID: 56564 RVA: 0x003434EC File Offset: 0x003416EC
			// (set) Token: 0x0600DCF5 RID: 56565 RVA: 0x0006BAD6 File Offset: 0x00069CD6
			public unsafe CharacterCreatorOptionList __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCreatorOptionList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009409 RID: 37897
			private static readonly IntPtr NativeFieldInfoPtr_option;

			// Token: 0x0400940A RID: 37898
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400940B RID: 37899
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400940C RID: 37900
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;
		}

		// Token: 0x02000BAE RID: 2990
		[ObfuscatedName("ScheduleOne.UI.CharacterCreator.CharacterCreatorOptionList+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DCF6 RID: 56566 RVA: 0x0034351C File Offset: 0x0034171C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass9_0>.NativeClassPtr);
				CharacterCreatorOptionList.__c__DisplayClass9_0.NativeFieldInfoPtr_option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass9_0>.NativeClassPtr, "option");
				CharacterCreatorOptionList.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass9_0>.NativeClassPtr, 100682954);
				CharacterCreatorOptionList.__c__DisplayClass9_0.NativeMethodInfoPtr__OptionClicked_b__0_Internal_Boolean_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass9_0>.NativeClassPtr, 100682955);
			}

			// Token: 0x0600DCF7 RID: 56567 RVA: 0x00343584 File Offset: 0x00341784
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCF8 RID: 56568 RVA: 0x003435C0 File Offset: 0x003417C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OptionClicked_b__0(CharacterCreatorOptionList.Option o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.__c__DisplayClass9_0.NativeMethodInfoPtr__OptionClicked_b__0_Internal_Boolean_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DCF9 RID: 56569 RVA: 0x0006BAF5 File Offset: 0x00069CF5
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700447C RID: 17532
			// (get) Token: 0x0600DCFA RID: 56570 RVA: 0x00343610 File Offset: 0x00341810
			// (set) Token: 0x0600DCFB RID: 56571 RVA: 0x0006BAFE File Offset: 0x00069CFE
			public unsafe string option
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.__c__DisplayClass9_0.NativeFieldInfoPtr_option);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.__c__DisplayClass9_0.NativeFieldInfoPtr_option), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400940D RID: 37901
			private static readonly IntPtr NativeFieldInfoPtr_option;

			// Token: 0x0400940E RID: 37902
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400940F RID: 37903
			private static readonly IntPtr NativeMethodInfoPtr__OptionClicked_b__0_Internal_Boolean_Option_0;
		}
	}
}
