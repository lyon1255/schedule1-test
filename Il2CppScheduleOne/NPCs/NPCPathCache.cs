using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020002DA RID: 730
	public class NPCPathCache : Il2CppSystem.Object
	{
		// Token: 0x060035E3 RID: 13795 RVA: 0x0011DDC4 File Offset: 0x0011BFC4
		// Note: this type is marked as 'beforefieldinit'.
		static NPCPathCache()
		{
			Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCPathCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr);
			NPCPathCache.NativeFieldInfoPtr__Paths_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, "<Paths>k__BackingField");
			NPCPathCache.NativeMethodInfoPtr_get_Paths_Public_get_List_1_PathCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, 100669408);
			NPCPathCache.NativeMethodInfoPtr_set_Paths_Private_set_Void_List_1_PathCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, 100669409);
			NPCPathCache.NativeMethodInfoPtr_GetPath_Public_NavMeshPath_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, 100669410);
			NPCPathCache.NativeMethodInfoPtr_AddPath_Public_Void_Vector3_Vector3_NavMeshPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, 100669411);
			NPCPathCache.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, 100669412);
		}

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x060035E4 RID: 13796 RVA: 0x0011DE6C File Offset: 0x0011C06C
		// (set) Token: 0x060035E5 RID: 13797 RVA: 0x0011DEAC File Offset: 0x0011C0AC
		public unsafe List<NPCPathCache.PathCache> Paths
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 17383, RefRangeEnd = 17393, XrefRangeStart = 17383, XrefRangeEnd = 17393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPathCache.NativeMethodInfoPtr_get_Paths_Public_get_List_1_PathCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPCPathCache.PathCache>>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29994, RefRangeEnd = 29996, XrefRangeStart = 29994, XrefRangeEnd = 29996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPathCache.NativeMethodInfoPtr_set_Paths_Private_set_Void_List_1_PathCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035E6 RID: 13798 RVA: 0x0011DEF0 File Offset: 0x0011C0F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137952, RefRangeEnd = 137953, XrefRangeStart = 137942, XrefRangeEnd = 137952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavMeshPath GetPath(Vector3 start, Vector3 end, float sqrMaxDistance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sqrMaxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPathCache.NativeMethodInfoPtr_GetPath_Public_NavMeshPath_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NavMeshPath>(intPtr3) : null;
		}

		// Token: 0x060035E7 RID: 13799 RVA: 0x0011DF58 File Offset: 0x0011C158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137953, XrefRangeEnd = 137961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPath(Vector3 start, Vector3 end, NavMeshPath path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPathCache.NativeMethodInfoPtr_AddPath_Public_Void_Vector3_Vector3_NavMeshPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E8 RID: 13800 RVA: 0x0011DFB8 File Offset: 0x0011C1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137961, XrefRangeEnd = 137969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCPathCache() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPathCache.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E9 RID: 13801 RVA: 0x0001C4C9 File Offset: 0x0001A6C9
		public NPCPathCache(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x060035EA RID: 13802 RVA: 0x0011DFF4 File Offset: 0x0011C1F4
		// (set) Token: 0x060035EB RID: 13803 RVA: 0x0001C4D2 File Offset: 0x0001A6D2
		public unsafe List<NPCPathCache.PathCache> _Paths_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.NativeFieldInfoPtr__Paths_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCPathCache.PathCache>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.NativeFieldInfoPtr__Paths_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400233E RID: 9022
		private static readonly IntPtr NativeFieldInfoPtr__Paths_k__BackingField;

		// Token: 0x0400233F RID: 9023
		private static readonly IntPtr NativeMethodInfoPtr_get_Paths_Public_get_List_1_PathCache_0;

		// Token: 0x04002340 RID: 9024
		private static readonly IntPtr NativeMethodInfoPtr_set_Paths_Private_set_Void_List_1_PathCache_0;

		// Token: 0x04002341 RID: 9025
		private static readonly IntPtr NativeMethodInfoPtr_GetPath_Public_NavMeshPath_Vector3_Vector3_Single_0;

		// Token: 0x04002342 RID: 9026
		private static readonly IntPtr NativeMethodInfoPtr_AddPath_Public_Void_Vector3_Vector3_NavMeshPath_0;

		// Token: 0x04002343 RID: 9027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000925 RID: 2341
		[Serializable]
		public class PathCache : Il2CppSystem.Object
		{
			// Token: 0x0600C671 RID: 50801 RVA: 0x00303128 File Offset: 0x00301328
			// Note: this type is marked as 'beforefieldinit'.
			static PathCache()
			{
				Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, "PathCache");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr);
				NPCPathCache.PathCache.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr, "Start");
				NPCPathCache.PathCache.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr, "End");
				NPCPathCache.PathCache.NativeFieldInfoPtr_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr, "Path");
				NPCPathCache.PathCache.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_NavMeshPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr, 100669413);
			}

			// Token: 0x0600C672 RID: 50802 RVA: 0x003031A4 File Offset: 0x003013A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137940, XrefRangeEnd = 137942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PathCache(Vector3 start, Vector3 end, NavMeshPath path) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref start;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPathCache.PathCache.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_NavMeshPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C673 RID: 50803 RVA: 0x0006096E File Offset: 0x0005EB6E
			public PathCache(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DD5 RID: 15829
			// (get) Token: 0x0600C674 RID: 50804 RVA: 0x0030320C File Offset: 0x0030140C
			// (set) Token: 0x0600C675 RID: 50805 RVA: 0x00060977 File Offset: 0x0005EB77
			public unsafe Vector3 Start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.PathCache.NativeFieldInfoPtr_Start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.PathCache.NativeFieldInfoPtr_Start)) = value;
				}
			}

			// Token: 0x17003DD6 RID: 15830
			// (get) Token: 0x0600C676 RID: 50806 RVA: 0x00303234 File Offset: 0x00301434
			// (set) Token: 0x0600C677 RID: 50807 RVA: 0x00060992 File Offset: 0x0005EB92
			public unsafe Vector3 End
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.PathCache.NativeFieldInfoPtr_End);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.PathCache.NativeFieldInfoPtr_End)) = value;
				}
			}

			// Token: 0x17003DD7 RID: 15831
			// (get) Token: 0x0600C678 RID: 50808 RVA: 0x0030325C File Offset: 0x0030145C
			// (set) Token: 0x0600C679 RID: 50809 RVA: 0x000609AD File Offset: 0x0005EBAD
			public unsafe NavMeshPath Path
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.PathCache.NativeFieldInfoPtr_Path);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavMeshPath>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.PathCache.NativeFieldInfoPtr_Path), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400865A RID: 34394
			private static readonly IntPtr NativeFieldInfoPtr_Start;

			// Token: 0x0400865B RID: 34395
			private static readonly IntPtr NativeFieldInfoPtr_End;

			// Token: 0x0400865C RID: 34396
			private static readonly IntPtr NativeFieldInfoPtr_Path;

			// Token: 0x0400865D RID: 34397
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_NavMeshPath_0;
		}
	}
}
