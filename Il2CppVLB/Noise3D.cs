using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000A5 RID: 165
	public static class Noise3D : Il2CppSystem.Object
	{
		// Token: 0x06000B41 RID: 2881 RVA: 0x000943D0 File Offset: 0x000925D0
		// Note: this type is marked as 'beforefieldinit'.
		static Noise3D()
		{
			Il2CppClassPointerStore<Noise3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "Noise3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Noise3D>.NativeClassPtr);
			Noise3D.NativeFieldInfoPtr_ms_IsSupportedChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, "ms_IsSupportedChecked");
			Noise3D.NativeFieldInfoPtr_ms_IsSupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, "ms_IsSupported");
			Noise3D.NativeFieldInfoPtr_ms_NoiseTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, "ms_NoiseTexture");
			Noise3D.NativeFieldInfoPtr_kMinShaderLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, "kMinShaderLevel");
			Noise3D.NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, 100664633);
			Noise3D.NativeMethodInfoPtr_get_isProperlyLoaded_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, 100664634);
			Noise3D.NativeMethodInfoPtr_get_isNotSupportedString_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, 100664635);
			Noise3D.NativeMethodInfoPtr_OnStartUp_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, 100664636);
			Noise3D.NativeMethodInfoPtr_LoadIfNeeded_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, 100664637);
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x000944B4 File Offset: 0x000926B4
		public unsafe static bool isSupported
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 82680, RefRangeEnd = 82690, XrefRangeStart = 82660, XrefRangeEnd = 82680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Noise3D.NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x000944E4 File Offset: 0x000926E4
		public unsafe static bool isProperlyLoaded
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82690, XrefRangeEnd = 82696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Noise3D.NativeMethodInfoPtr_get_isProperlyLoaded_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000B44 RID: 2884 RVA: 0x00094514 File Offset: 0x00092714
		public unsafe static string isNotSupportedString
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 82705, RefRangeEnd = 82706, XrefRangeStart = 82696, XrefRangeEnd = 82705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Noise3D.NativeMethodInfoPtr_get_isNotSupportedString_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00094540 File Offset: 0x00092740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82706, XrefRangeEnd = 82707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnStartUp()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Noise3D.NativeMethodInfoPtr_OnStartUp_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00094568 File Offset: 0x00092768
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 82726, RefRangeEnd = 82729, XrefRangeStart = 82707, XrefRangeEnd = 82726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadIfNeeded()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Noise3D.NativeMethodInfoPtr_LoadIfNeeded_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00007B60 File Offset: 0x00005D60
		public Noise3D(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x00094590 File Offset: 0x00092790
		// (set) Token: 0x06000B49 RID: 2889 RVA: 0x00007B69 File Offset: 0x00005D69
		public unsafe static bool ms_IsSupportedChecked
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Noise3D.NativeFieldInfoPtr_ms_IsSupportedChecked, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Noise3D.NativeFieldInfoPtr_ms_IsSupportedChecked, (void*)(&value));
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000B4A RID: 2890 RVA: 0x000945AC File Offset: 0x000927AC
		// (set) Token: 0x06000B4B RID: 2891 RVA: 0x00007B77 File Offset: 0x00005D77
		public unsafe static bool ms_IsSupported
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Noise3D.NativeFieldInfoPtr_ms_IsSupported, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Noise3D.NativeFieldInfoPtr_ms_IsSupported, (void*)(&value));
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000B4C RID: 2892 RVA: 0x000945C8 File Offset: 0x000927C8
		// (set) Token: 0x06000B4D RID: 2893 RVA: 0x00007B85 File Offset: 0x00005D85
		public unsafe static Texture3D ms_NoiseTexture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Noise3D.NativeFieldInfoPtr_ms_NoiseTexture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture3D>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Noise3D.NativeFieldInfoPtr_ms_NoiseTexture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x000945F0 File Offset: 0x000927F0
		// (set) Token: 0x06000B4F RID: 2895 RVA: 0x00007B97 File Offset: 0x00005D97
		public unsafe static int kMinShaderLevel
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Noise3D.NativeFieldInfoPtr_kMinShaderLevel, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Noise3D.NativeFieldInfoPtr_kMinShaderLevel, (void*)(&value));
			}
		}

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeFieldInfoPtr_ms_IsSupportedChecked;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeFieldInfoPtr_ms_IsSupported;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeFieldInfoPtr_ms_NoiseTexture;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeFieldInfoPtr_kMinShaderLevel;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeMethodInfoPtr_get_isProperlyLoaded_Public_Static_get_Boolean_0;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeMethodInfoPtr_get_isNotSupportedString_Public_Static_get_String_0;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeMethodInfoPtr_OnStartUp_Private_Static_Void_0;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeMethodInfoPtr_LoadIfNeeded_Public_Static_Void_0;
	}
}
