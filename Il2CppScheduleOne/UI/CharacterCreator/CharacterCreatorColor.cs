using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCreator
{
	// Token: 0x020006FC RID: 1788
	public class CharacterCreatorColor : CharacterCreatorField<Color>
	{
		// Token: 0x0600A075 RID: 41077 RVA: 0x002866B4 File Offset: 0x002848B4
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCreatorColor()
		{
			Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCreator", "CharacterCreatorColor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr);
			CharacterCreatorColor.NativeFieldInfoPtr_ClothingColorsToUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "ClothingColorsToUse");
			CharacterCreatorColor.NativeFieldInfoPtr_OptionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "OptionContainer");
			CharacterCreatorColor.NativeFieldInfoPtr_UseClothingColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "UseClothingColors");
			CharacterCreatorColor.NativeFieldInfoPtr_Colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "Colors");
			CharacterCreatorColor.NativeFieldInfoPtr_OptionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "OptionPrefab");
			CharacterCreatorColor.NativeFieldInfoPtr_optionButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "optionButtons");
			CharacterCreatorColor.NativeFieldInfoPtr_selectedButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "selectedButton");
			CharacterCreatorColor.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, 100682926);
			CharacterCreatorColor.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, 100682927);
			CharacterCreatorColor.NativeMethodInfoPtr_OptionClicked_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, 100682928);
			CharacterCreatorColor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, 100682929);
		}

		// Token: 0x0600A076 RID: 41078 RVA: 0x002867C0 File Offset: 0x002849C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282262, XrefRangeEnd = 282321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorColor.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A077 RID: 41079 RVA: 0x002867FC File Offset: 0x002849FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282321, XrefRangeEnd = 282345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorColor.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A078 RID: 41080 RVA: 0x00286838 File Offset: 0x00284A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282345, XrefRangeEnd = 282356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionClicked(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorColor.NativeMethodInfoPtr_OptionClicked_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A079 RID: 41081 RVA: 0x00286878 File Offset: 0x00284A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282356, XrefRangeEnd = 282366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCreatorColor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorColor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A07A RID: 41082 RVA: 0x0004EEA2 File Offset: 0x0004D0A2
		public CharacterCreatorColor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003173 RID: 12659
		// (get) Token: 0x0600A07B RID: 41083 RVA: 0x002868B4 File Offset: 0x00284AB4
		// (set) Token: 0x0600A07C RID: 41084 RVA: 0x0004EEAB File Offset: 0x0004D0AB
		public unsafe static Il2CppStructArray<EClothingColor> ClothingColorsToUse
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CharacterCreatorColor.NativeFieldInfoPtr_ClothingColorsToUse, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<EClothingColor>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharacterCreatorColor.NativeFieldInfoPtr_ClothingColorsToUse, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003174 RID: 12660
		// (get) Token: 0x0600A07D RID: 41085 RVA: 0x002868DC File Offset: 0x00284ADC
		// (set) Token: 0x0600A07E RID: 41086 RVA: 0x0004EEBD File Offset: 0x0004D0BD
		public unsafe RectTransform OptionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_OptionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_OptionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003175 RID: 12661
		// (get) Token: 0x0600A07F RID: 41087 RVA: 0x0028690C File Offset: 0x00284B0C
		// (set) Token: 0x0600A080 RID: 41088 RVA: 0x0004EEDC File Offset: 0x0004D0DC
		public unsafe bool UseClothingColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_UseClothingColors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_UseClothingColors)) = value;
			}
		}

		// Token: 0x17003176 RID: 12662
		// (get) Token: 0x0600A081 RID: 41089 RVA: 0x00286934 File Offset: 0x00284B34
		// (set) Token: 0x0600A082 RID: 41090 RVA: 0x0004EEF7 File Offset: 0x0004D0F7
		public unsafe List<Color> Colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_Colors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_Colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003177 RID: 12663
		// (get) Token: 0x0600A083 RID: 41091 RVA: 0x00286964 File Offset: 0x00284B64
		// (set) Token: 0x0600A084 RID: 41092 RVA: 0x0004EF16 File Offset: 0x0004D116
		public unsafe GameObject OptionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_OptionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_OptionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003178 RID: 12664
		// (get) Token: 0x0600A085 RID: 41093 RVA: 0x00286994 File Offset: 0x00284B94
		// (set) Token: 0x0600A086 RID: 41094 RVA: 0x0004EF35 File Offset: 0x0004D135
		public unsafe List<Button> optionButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_optionButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_optionButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003179 RID: 12665
		// (get) Token: 0x0600A087 RID: 41095 RVA: 0x002869C4 File Offset: 0x00284BC4
		// (set) Token: 0x0600A088 RID: 41096 RVA: 0x0004EF54 File Offset: 0x0004D154
		public unsafe Button selectedButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_selectedButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_selectedButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006B95 RID: 27541
		private static readonly IntPtr NativeFieldInfoPtr_ClothingColorsToUse;

		// Token: 0x04006B96 RID: 27542
		private static readonly IntPtr NativeFieldInfoPtr_OptionContainer;

		// Token: 0x04006B97 RID: 27543
		private static readonly IntPtr NativeFieldInfoPtr_UseClothingColors;

		// Token: 0x04006B98 RID: 27544
		private static readonly IntPtr NativeFieldInfoPtr_Colors;

		// Token: 0x04006B99 RID: 27545
		private static readonly IntPtr NativeFieldInfoPtr_OptionPrefab;

		// Token: 0x04006B9A RID: 27546
		private static readonly IntPtr NativeFieldInfoPtr_optionButtons;

		// Token: 0x04006B9B RID: 27547
		private static readonly IntPtr NativeFieldInfoPtr_selectedButton;

		// Token: 0x04006B9C RID: 27548
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006B9D RID: 27549
		private static readonly IntPtr NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0;

		// Token: 0x04006B9E RID: 27550
		private static readonly IntPtr NativeMethodInfoPtr_OptionClicked_Public_Void_Color_0;

		// Token: 0x04006B9F RID: 27551
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BAA RID: 2986
		[ObfuscatedName("ScheduleOne.UI.CharacterCreator.CharacterCreatorColor+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DCD4 RID: 56532 RVA: 0x00342FD0 File Offset: 0x003411D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr);
				CharacterCreatorColor.__c__DisplayClass7_0.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr, "col");
				CharacterCreatorColor.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				CharacterCreatorColor.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr, 100682931);
				CharacterCreatorColor.__c__DisplayClass7_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr, 100682932);
			}

			// Token: 0x0600DCD5 RID: 56533 RVA: 0x0034304C File Offset: 0x0034124C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorColor.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCD6 RID: 56534 RVA: 0x00343088 File Offset: 0x00341288
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282260, XrefRangeEnd = 282262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorColor.__c__DisplayClass7_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCD7 RID: 56535 RVA: 0x0006B9BE File Offset: 0x00069BBE
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004473 RID: 17523
			// (get) Token: 0x0600DCD8 RID: 56536 RVA: 0x003430BC File Offset: 0x003412BC
			// (set) Token: 0x0600DCD9 RID: 56537 RVA: 0x0006B9C7 File Offset: 0x00069BC7
			public unsafe Color col
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.__c__DisplayClass7_0.NativeFieldInfoPtr_col);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.__c__DisplayClass7_0.NativeFieldInfoPtr_col)) = value;
				}
			}

			// Token: 0x17004474 RID: 17524
			// (get) Token: 0x0600DCDA RID: 56538 RVA: 0x003430E4 File Offset: 0x003412E4
			// (set) Token: 0x0600DCDB RID: 56539 RVA: 0x0006B9E2 File Offset: 0x00069BE2
			public unsafe CharacterCreatorColor __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCreatorColor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040093FC RID: 37884
			private static readonly IntPtr NativeFieldInfoPtr_col;

			// Token: 0x040093FD RID: 37885
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040093FE RID: 37886
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040093FF RID: 37887
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;
		}
	}
}
