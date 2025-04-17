using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppPathfinding;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x02000501 RID: 1281
	public class PathGroup : Il2CppSystem.Object
	{
		// Token: 0x060070E3 RID: 28899 RVA: 0x001EFC44 File Offset: 0x001EDE44
		// Note: this type is marked as 'beforefieldinit'.
		static PathGroup()
		{
			Il2CppClassPointerStore<PathGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "PathGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathGroup>.NativeClassPtr);
			PathGroup.NativeFieldInfoPtr_entryPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathGroup>.NativeClassPtr, "entryPoint");
			PathGroup.NativeFieldInfoPtr_startToEntryPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathGroup>.NativeClassPtr, "startToEntryPath");
			PathGroup.NativeFieldInfoPtr_entryToExitPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathGroup>.NativeClassPtr, "entryToExitPath");
			PathGroup.NativeFieldInfoPtr_exitToDestinationPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathGroup>.NativeClassPtr, "exitToDestinationPath");
			PathGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathGroup>.NativeClassPtr, 100677505);
		}

		// Token: 0x060070E4 RID: 28900 RVA: 0x001EFCD8 File Offset: 0x001EDED8
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathGroup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070E5 RID: 28901 RVA: 0x000359AB File Offset: 0x00033BAB
		public PathGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700221C RID: 8732
		// (get) Token: 0x060070E6 RID: 28902 RVA: 0x001EFD14 File Offset: 0x001EDF14
		// (set) Token: 0x060070E7 RID: 28903 RVA: 0x000359B4 File Offset: 0x00033BB4
		public unsafe Vector3 entryPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_entryPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_entryPoint)) = value;
			}
		}

		// Token: 0x1700221D RID: 8733
		// (get) Token: 0x060070E8 RID: 28904 RVA: 0x001EFD3C File Offset: 0x001EDF3C
		// (set) Token: 0x060070E9 RID: 28905 RVA: 0x000359CF File Offset: 0x00033BCF
		public unsafe Path startToEntryPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_startToEntryPath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_startToEntryPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700221E RID: 8734
		// (get) Token: 0x060070EA RID: 28906 RVA: 0x001EFD6C File Offset: 0x001EDF6C
		// (set) Token: 0x060070EB RID: 28907 RVA: 0x000359EE File Offset: 0x00033BEE
		public unsafe Path entryToExitPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_entryToExitPath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_entryToExitPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700221F RID: 8735
		// (get) Token: 0x060070EC RID: 28908 RVA: 0x001EFD9C File Offset: 0x001EDF9C
		// (set) Token: 0x060070ED RID: 28909 RVA: 0x00035A0D File Offset: 0x00033C0D
		public unsafe Path exitToDestinationPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_exitToDestinationPath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_exitToDestinationPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D1D RID: 19741
		private static readonly IntPtr NativeFieldInfoPtr_entryPoint;

		// Token: 0x04004D1E RID: 19742
		private static readonly IntPtr NativeFieldInfoPtr_startToEntryPath;

		// Token: 0x04004D1F RID: 19743
		private static readonly IntPtr NativeFieldInfoPtr_entryToExitPath;

		// Token: 0x04004D20 RID: 19744
		private static readonly IntPtr NativeFieldInfoPtr_exitToDestinationPath;

		// Token: 0x04004D21 RID: 19745
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
