using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000596 RID: 1430
	[Serializable]
	public class CocaineAppearanceSettings : Il2CppSystem.Object
	{
		// Token: 0x06007DBC RID: 32188 RVA: 0x0021A904 File Offset: 0x00218B04
		// Note: this type is marked as 'beforefieldinit'.
		static CocaineAppearanceSettings()
		{
			Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "CocaineAppearanceSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr);
			CocaineAppearanceSettings.NativeFieldInfoPtr_MainColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr, "MainColor");
			CocaineAppearanceSettings.NativeFieldInfoPtr_SecondaryColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr, "SecondaryColor");
			CocaineAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr, 100679015);
			CocaineAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr, 100679016);
			CocaineAppearanceSettings.NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr, 100679017);
		}

		// Token: 0x06007DBD RID: 32189 RVA: 0x0021A998 File Offset: 0x00218B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238072, XrefRangeEnd = 238073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineAppearanceSettings(Color32 mainColor, Color32 secondaryColor) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mainColor;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondaryColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DBE RID: 32190 RVA: 0x0021A9F0 File Offset: 0x00218BF0
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineAppearanceSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DBF RID: 32191 RVA: 0x0021AA2C File Offset: 0x00218C2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 238073, RefRangeEnd = 238075, XrefRangeStart = 238073, XrefRangeEnd = 238073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsUnintialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineAppearanceSettings.NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007DC0 RID: 32192 RVA: 0x0003BCA4 File Offset: 0x00039EA4
		public CocaineAppearanceSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002613 RID: 9747
		// (get) Token: 0x06007DC1 RID: 32193 RVA: 0x0021AA68 File Offset: 0x00218C68
		// (set) Token: 0x06007DC2 RID: 32194 RVA: 0x0003BCAD File Offset: 0x00039EAD
		public unsafe Color32 MainColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineAppearanceSettings.NativeFieldInfoPtr_MainColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineAppearanceSettings.NativeFieldInfoPtr_MainColor)) = value;
			}
		}

		// Token: 0x17002614 RID: 9748
		// (get) Token: 0x06007DC3 RID: 32195 RVA: 0x0021AA90 File Offset: 0x00218C90
		// (set) Token: 0x06007DC4 RID: 32196 RVA: 0x0003BCC8 File Offset: 0x00039EC8
		public unsafe Color32 SecondaryColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineAppearanceSettings.NativeFieldInfoPtr_SecondaryColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineAppearanceSettings.NativeFieldInfoPtr_SecondaryColor)) = value;
			}
		}

		// Token: 0x04005580 RID: 21888
		private static readonly IntPtr NativeFieldInfoPtr_MainColor;

		// Token: 0x04005581 RID: 21889
		private static readonly IntPtr NativeFieldInfoPtr_SecondaryColor;

		// Token: 0x04005582 RID: 21890
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_0;

		// Token: 0x04005583 RID: 21891
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005584 RID: 21892
		private static readonly IntPtr NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0;
	}
}
