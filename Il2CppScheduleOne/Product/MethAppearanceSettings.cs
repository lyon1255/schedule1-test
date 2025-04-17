using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x0200059F RID: 1439
	[Serializable]
	public class MethAppearanceSettings : Il2CppSystem.Object
	{
		// Token: 0x06007DF0 RID: 32240 RVA: 0x0021B538 File Offset: 0x00219738
		// Note: this type is marked as 'beforefieldinit'.
		static MethAppearanceSettings()
		{
			Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "MethAppearanceSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr);
			MethAppearanceSettings.NativeFieldInfoPtr_MainColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr, "MainColor");
			MethAppearanceSettings.NativeFieldInfoPtr_SecondaryColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr, "SecondaryColor");
			MethAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr, 100679044);
			MethAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr, 100679045);
			MethAppearanceSettings.NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr, 100679046);
		}

		// Token: 0x06007DF1 RID: 32241 RVA: 0x0021B5CC File Offset: 0x002197CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethAppearanceSettings(Color32 mainColor, Color32 secondaryColor) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mainColor;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondaryColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DF2 RID: 32242 RVA: 0x0021B624 File Offset: 0x00219824
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethAppearanceSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DF3 RID: 32243 RVA: 0x0021B660 File Offset: 0x00219860
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 238073, RefRangeEnd = 238075, XrefRangeStart = 238073, XrefRangeEnd = 238075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsUnintialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethAppearanceSettings.NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007DF4 RID: 32244 RVA: 0x0003BD8D File Offset: 0x00039F8D
		public MethAppearanceSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700261A RID: 9754
		// (get) Token: 0x06007DF5 RID: 32245 RVA: 0x0021B69C File Offset: 0x0021989C
		// (set) Token: 0x06007DF6 RID: 32246 RVA: 0x0003BD96 File Offset: 0x00039F96
		public unsafe Color32 MainColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethAppearanceSettings.NativeFieldInfoPtr_MainColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethAppearanceSettings.NativeFieldInfoPtr_MainColor)) = value;
			}
		}

		// Token: 0x1700261B RID: 9755
		// (get) Token: 0x06007DF7 RID: 32247 RVA: 0x0021B6C4 File Offset: 0x002198C4
		// (set) Token: 0x06007DF8 RID: 32248 RVA: 0x0003BDB1 File Offset: 0x00039FB1
		public unsafe Color32 SecondaryColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethAppearanceSettings.NativeFieldInfoPtr_SecondaryColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethAppearanceSettings.NativeFieldInfoPtr_SecondaryColor)) = value;
			}
		}

		// Token: 0x040055B9 RID: 21945
		private static readonly IntPtr NativeFieldInfoPtr_MainColor;

		// Token: 0x040055BA RID: 21946
		private static readonly IntPtr NativeFieldInfoPtr_SecondaryColor;

		// Token: 0x040055BB RID: 21947
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_0;

		// Token: 0x040055BC RID: 21948
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040055BD RID: 21949
		private static readonly IntPtr NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0;
	}
}
