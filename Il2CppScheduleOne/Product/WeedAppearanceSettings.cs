using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005AF RID: 1455
	[Serializable]
	public class WeedAppearanceSettings : Il2CppSystem.Object
	{
		// Token: 0x06007FEB RID: 32747 RVA: 0x00223BAC File Offset: 0x00221DAC
		// Note: this type is marked as 'beforefieldinit'.
		static WeedAppearanceSettings()
		{
			Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "WeedAppearanceSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr);
			WeedAppearanceSettings.NativeFieldInfoPtr_MainColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, "MainColor");
			WeedAppearanceSettings.NativeFieldInfoPtr_SecondaryColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, "SecondaryColor");
			WeedAppearanceSettings.NativeFieldInfoPtr_LeafColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, "LeafColor");
			WeedAppearanceSettings.NativeFieldInfoPtr_StemColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, "StemColor");
			WeedAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, 100679369);
			WeedAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, 100679370);
			WeedAppearanceSettings.NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, 100679371);
		}

		// Token: 0x06007FEC RID: 32748 RVA: 0x00223C68 File Offset: 0x00221E68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243480, RefRangeEnd = 243481, XrefRangeStart = 243479, XrefRangeEnd = 243480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeedAppearanceSettings(Color32 mainColor, Color32 secondaryColor, Color32 leafColor, Color32 stemColor) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mainColor;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondaryColor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leafColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stemColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_Color32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FED RID: 32749 RVA: 0x00223CDC File Offset: 0x00221EDC
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeedAppearanceSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FEE RID: 32750 RVA: 0x00223D18 File Offset: 0x00221F18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243481, RefRangeEnd = 243482, XrefRangeStart = 243481, XrefRangeEnd = 243481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsUnintialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedAppearanceSettings.NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007FEF RID: 32751 RVA: 0x0003CA29 File Offset: 0x0003AC29
		public WeedAppearanceSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026A4 RID: 9892
		// (get) Token: 0x06007FF0 RID: 32752 RVA: 0x00223D54 File Offset: 0x00221F54
		// (set) Token: 0x06007FF1 RID: 32753 RVA: 0x0003CA32 File Offset: 0x0003AC32
		public unsafe Color32 MainColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_MainColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_MainColor)) = value;
			}
		}

		// Token: 0x170026A5 RID: 9893
		// (get) Token: 0x06007FF2 RID: 32754 RVA: 0x00223D7C File Offset: 0x00221F7C
		// (set) Token: 0x06007FF3 RID: 32755 RVA: 0x0003CA4D File Offset: 0x0003AC4D
		public unsafe Color32 SecondaryColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_SecondaryColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_SecondaryColor)) = value;
			}
		}

		// Token: 0x170026A6 RID: 9894
		// (get) Token: 0x06007FF4 RID: 32756 RVA: 0x00223DA4 File Offset: 0x00221FA4
		// (set) Token: 0x06007FF5 RID: 32757 RVA: 0x0003CA68 File Offset: 0x0003AC68
		public unsafe Color32 LeafColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_LeafColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_LeafColor)) = value;
			}
		}

		// Token: 0x170026A7 RID: 9895
		// (get) Token: 0x06007FF6 RID: 32758 RVA: 0x00223DCC File Offset: 0x00221FCC
		// (set) Token: 0x06007FF7 RID: 32759 RVA: 0x0003CA83 File Offset: 0x0003AC83
		public unsafe Color32 StemColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_StemColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_StemColor)) = value;
			}
		}

		// Token: 0x04005729 RID: 22313
		private static readonly IntPtr NativeFieldInfoPtr_MainColor;

		// Token: 0x0400572A RID: 22314
		private static readonly IntPtr NativeFieldInfoPtr_SecondaryColor;

		// Token: 0x0400572B RID: 22315
		private static readonly IntPtr NativeFieldInfoPtr_LeafColor;

		// Token: 0x0400572C RID: 22316
		private static readonly IntPtr NativeFieldInfoPtr_StemColor;

		// Token: 0x0400572D RID: 22317
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_Color32_Color32_0;

		// Token: 0x0400572E RID: 22318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400572F RID: 22319
		private static readonly IntPtr NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0;
	}
}
