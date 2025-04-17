using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Settings;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020006ED RID: 1773
	public class SettingsScreen : MainMenuScreen
	{
		// Token: 0x06009EA5 RID: 40613 RVA: 0x00281104 File Offset: 0x0027F304
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsScreen()
		{
			Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "SettingsScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr);
			SettingsScreen.NativeFieldInfoPtr_Categories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, "Categories");
			SettingsScreen.NativeFieldInfoPtr_ApplyDisplayButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, "ApplyDisplayButton");
			SettingsScreen.NativeFieldInfoPtr_ConfirmDisplaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, "ConfirmDisplaySettings");
			SettingsScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, 100682760);
			SettingsScreen.NativeMethodInfoPtr_Start_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, 100682761);
			SettingsScreen.NativeMethodInfoPtr_ShowCategory_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, 100682762);
			SettingsScreen.NativeMethodInfoPtr_DisplayChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, 100682763);
			SettingsScreen.NativeMethodInfoPtr_ApplyDisplaySettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, 100682764);
			SettingsScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, 100682765);
		}

		// Token: 0x06009EA6 RID: 40614 RVA: 0x002811E8 File Offset: 0x0027F3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280379, XrefRangeEnd = 280390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EA7 RID: 40615 RVA: 0x00281224 File Offset: 0x0027F424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280390, XrefRangeEnd = 280406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.NativeMethodInfoPtr_Start_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EA8 RID: 40616 RVA: 0x00281258 File Offset: 0x0027F458
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280409, RefRangeEnd = 280410, XrefRangeStart = 280406, XrefRangeEnd = 280409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowCategory(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.NativeMethodInfoPtr_ShowCategory_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EA9 RID: 40617 RVA: 0x00281298 File Offset: 0x0027F498
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 280413, RefRangeEnd = 280420, XrefRangeStart = 280410, XrefRangeEnd = 280413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.NativeMethodInfoPtr_DisplayChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EAA RID: 40618 RVA: 0x002812CC File Offset: 0x0027F4CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280420, XrefRangeEnd = 280434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDisplaySettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.NativeMethodInfoPtr_ApplyDisplaySettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EAB RID: 40619 RVA: 0x00281300 File Offset: 0x0027F500
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EAC RID: 40620 RVA: 0x0004DCE2 File Offset: 0x0004BEE2
		public SettingsScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030D2 RID: 12498
		// (get) Token: 0x06009EAD RID: 40621 RVA: 0x0028133C File Offset: 0x0027F53C
		// (set) Token: 0x06009EAE RID: 40622 RVA: 0x0004DCEB File Offset: 0x0004BEEB
		public unsafe Il2CppReferenceArray<SettingsScreen.SettingsCategory> Categories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_Categories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SettingsScreen.SettingsCategory>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_Categories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030D3 RID: 12499
		// (get) Token: 0x06009EAF RID: 40623 RVA: 0x0028136C File Offset: 0x0027F56C
		// (set) Token: 0x06009EB0 RID: 40624 RVA: 0x0004DD0A File Offset: 0x0004BF0A
		public unsafe Button ApplyDisplayButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_ApplyDisplayButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_ApplyDisplayButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030D4 RID: 12500
		// (get) Token: 0x06009EB1 RID: 40625 RVA: 0x0028139C File Offset: 0x0027F59C
		// (set) Token: 0x06009EB2 RID: 40626 RVA: 0x0004DD29 File Offset: 0x0004BF29
		public unsafe ConfirmDisplaySettings ConfirmDisplaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_ConfirmDisplaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmDisplaySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_ConfirmDisplaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A78 RID: 27256
		private static readonly IntPtr NativeFieldInfoPtr_Categories;

		// Token: 0x04006A79 RID: 27257
		private static readonly IntPtr NativeFieldInfoPtr_ApplyDisplayButton;

		// Token: 0x04006A7A RID: 27258
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmDisplaySettings;

		// Token: 0x04006A7B RID: 27259
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006A7C RID: 27260
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Void_0;

		// Token: 0x04006A7D RID: 27261
		private static readonly IntPtr NativeMethodInfoPtr_ShowCategory_Public_Void_Int32_0;

		// Token: 0x04006A7E RID: 27262
		private static readonly IntPtr NativeMethodInfoPtr_DisplayChanged_Public_Void_0;

		// Token: 0x04006A7F RID: 27263
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDisplaySettings_Private_Void_0;

		// Token: 0x04006A80 RID: 27264
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B9D RID: 2973
		[Serializable]
		public class SettingsCategory : Il2CppSystem.Object
		{
			// Token: 0x0600DC6B RID: 56427 RVA: 0x00341DEC File Offset: 0x0033FFEC
			// Note: this type is marked as 'beforefieldinit'.
			static SettingsCategory()
			{
				Il2CppClassPointerStore<SettingsScreen.SettingsCategory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, "SettingsCategory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsScreen.SettingsCategory>.NativeClassPtr);
				SettingsScreen.SettingsCategory.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen.SettingsCategory>.NativeClassPtr, "Button");
				SettingsScreen.SettingsCategory.NativeFieldInfoPtr_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen.SettingsCategory>.NativeClassPtr, "Panel");
				SettingsScreen.SettingsCategory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen.SettingsCategory>.NativeClassPtr, 100682766);
			}

			// Token: 0x0600DC6C RID: 56428 RVA: 0x00341E54 File Offset: 0x00340054
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SettingsCategory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsScreen.SettingsCategory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.SettingsCategory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC6D RID: 56429 RVA: 0x0006B612 File Offset: 0x00069812
			public SettingsCategory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004450 RID: 17488
			// (get) Token: 0x0600DC6E RID: 56430 RVA: 0x00341E90 File Offset: 0x00340090
			// (set) Token: 0x0600DC6F RID: 56431 RVA: 0x0006B61B File Offset: 0x0006981B
			public unsafe Button Button
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.SettingsCategory.NativeFieldInfoPtr_Button);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.SettingsCategory.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004451 RID: 17489
			// (get) Token: 0x0600DC70 RID: 56432 RVA: 0x00341EC0 File Offset: 0x003400C0
			// (set) Token: 0x0600DC71 RID: 56433 RVA: 0x0006B63A File Offset: 0x0006983A
			public unsafe GameObject Panel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.SettingsCategory.NativeFieldInfoPtr_Panel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.SettingsCategory.NativeFieldInfoPtr_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040093B4 RID: 37812
			private static readonly IntPtr NativeFieldInfoPtr_Button;

			// Token: 0x040093B5 RID: 37813
			private static readonly IntPtr NativeFieldInfoPtr_Panel;

			// Token: 0x040093B6 RID: 37814
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000B9E RID: 2974
		[ObfuscatedName("ScheduleOne.UI.MainMenu.SettingsScreen+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DC72 RID: 56434 RVA: 0x00341EF0 File Offset: 0x003400F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass5_0>.NativeClassPtr);
				SettingsScreen.__c__DisplayClass5_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass5_0>.NativeClassPtr, "index");
				SettingsScreen.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
				SettingsScreen.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass5_0>.NativeClassPtr, 100682767);
				SettingsScreen.__c__DisplayClass5_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass5_0>.NativeClassPtr, 100682768);
			}

			// Token: 0x0600DC73 RID: 56435 RVA: 0x00341F6C File Offset: 0x0034016C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC74 RID: 56436 RVA: 0x00341FA8 File Offset: 0x003401A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280377, XrefRangeEnd = 280379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.__c__DisplayClass5_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC75 RID: 56437 RVA: 0x0006B659 File Offset: 0x00069859
			public __c__DisplayClass5_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004452 RID: 17490
			// (get) Token: 0x0600DC76 RID: 56438 RVA: 0x00341FDC File Offset: 0x003401DC
			// (set) Token: 0x0600DC77 RID: 56439 RVA: 0x0006B662 File Offset: 0x00069862
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass5_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass5_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x17004453 RID: 17491
			// (get) Token: 0x0600DC78 RID: 56440 RVA: 0x00342004 File Offset: 0x00340204
			// (set) Token: 0x0600DC79 RID: 56441 RVA: 0x0006B67D File Offset: 0x0006987D
			public unsafe SettingsScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SettingsScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040093B7 RID: 37815
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x040093B8 RID: 37816
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040093B9 RID: 37817
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040093BA RID: 37818
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;
		}
	}
}
