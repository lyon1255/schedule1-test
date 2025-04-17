using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x02000098 RID: 152
	public static class GlobalMeshHD : Il2CppSystem.Object
	{
		// Token: 0x060009BF RID: 2495 RVA: 0x0008E910 File Offset: 0x0008CB10
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalMeshHD()
		{
			Il2CppClassPointerStore<GlobalMeshHD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "GlobalMeshHD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalMeshHD>.NativeClassPtr);
			GlobalMeshHD.NativeFieldInfoPtr_ms_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalMeshHD>.NativeClassPtr, "ms_Mesh");
			GlobalMeshHD.NativeMethodInfoPtr_Get_Public_Static_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalMeshHD>.NativeClassPtr, 100664366);
			GlobalMeshHD.NativeMethodInfoPtr_Destroy_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalMeshHD>.NativeClassPtr, 100664367);
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x0008E97C File Offset: 0x0008CB7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80801, RefRangeEnd = 80802, XrefRangeStart = 80770, XrefRangeEnd = 80801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalMeshHD.NativeMethodInfoPtr_Get_Public_Static_Mesh_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x0008E9B0 File Offset: 0x0008CBB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80802, XrefRangeEnd = 80815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Destroy()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalMeshHD.NativeMethodInfoPtr_Destroy_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x0000737A File Offset: 0x0000557A
		public GlobalMeshHD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x0008E9D8 File Offset: 0x0008CBD8
		// (set) Token: 0x060009C4 RID: 2500 RVA: 0x00007383 File Offset: 0x00005583
		public unsafe static Mesh ms_Mesh
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GlobalMeshHD.NativeFieldInfoPtr_ms_Mesh, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalMeshHD.NativeFieldInfoPtr_ms_Mesh, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeFieldInfoPtr_ms_Mesh;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_Mesh_0;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_0;
	}
}
