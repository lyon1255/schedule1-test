using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000AC RID: 172
	public static class GlobalMeshSD : Il2CppSystem.Object
	{
		// Token: 0x06000C0F RID: 3087 RVA: 0x000972E8 File Offset: 0x000954E8
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalMeshSD()
		{
			Il2CppClassPointerStore<GlobalMeshSD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "GlobalMeshSD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalMeshSD>.NativeClassPtr);
			GlobalMeshSD.NativeFieldInfoPtr_ms_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalMeshSD>.NativeClassPtr, "ms_Mesh");
			GlobalMeshSD.NativeFieldInfoPtr_ms_DoubleSided = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalMeshSD>.NativeClassPtr, "ms_DoubleSided");
			GlobalMeshSD.NativeMethodInfoPtr_Get_Public_Static_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalMeshSD>.NativeClassPtr, 100664772);
			GlobalMeshSD.NativeMethodInfoPtr_Destroy_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalMeshSD>.NativeClassPtr, 100664773);
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00097368 File Offset: 0x00095568
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83897, RefRangeEnd = 83898, XrefRangeStart = 83861, XrefRangeEnd = 83897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalMeshSD.NativeMethodInfoPtr_Get_Public_Static_Mesh_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x0009739C File Offset: 0x0009559C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83898, XrefRangeEnd = 83911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Destroy()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalMeshSD.NativeMethodInfoPtr_Destroy_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x00007FD0 File Offset: 0x000061D0
		public GlobalMeshSD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000C13 RID: 3091 RVA: 0x000973C4 File Offset: 0x000955C4
		// (set) Token: 0x06000C14 RID: 3092 RVA: 0x00007FD9 File Offset: 0x000061D9
		public unsafe static Mesh ms_Mesh
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GlobalMeshSD.NativeFieldInfoPtr_ms_Mesh, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalMeshSD.NativeFieldInfoPtr_ms_Mesh, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x000973EC File Offset: 0x000955EC
		// (set) Token: 0x06000C16 RID: 3094 RVA: 0x00007FEB File Offset: 0x000061EB
		public unsafe static bool ms_DoubleSided
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(GlobalMeshSD.NativeFieldInfoPtr_ms_DoubleSided, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalMeshSD.NativeFieldInfoPtr_ms_DoubleSided, (void*)(&value));
			}
		}

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeFieldInfoPtr_ms_Mesh;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeFieldInfoPtr_ms_DoubleSided;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_Mesh_0;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_0;
	}
}
