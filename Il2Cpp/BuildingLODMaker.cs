using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000016 RID: 22
	public class BuildingLODMaker : MonoBehaviour
	{
		// Token: 0x0600017E RID: 382 RVA: 0x0007550C File Offset: 0x0007370C
		// Note: this type is marked as 'beforefieldinit'.
		static BuildingLODMaker()
		{
			Il2CppClassPointerStore<BuildingLODMaker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BuildingLODMaker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildingLODMaker>.NativeClassPtr);
			BuildingLODMaker.NativeFieldInfoPtr_LODGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingLODMaker>.NativeClassPtr, "LODGroups");
			BuildingLODMaker.NativeFieldInfoPtr_LodGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingLODMaker>.NativeClassPtr, "LodGroup");
			BuildingLODMaker.NativeMethodInfoPtr_CreateLODs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingLODMaker>.NativeClassPtr, 100663422);
			BuildingLODMaker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingLODMaker>.NativeClassPtr, 100663423);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0007558C File Offset: 0x0007378C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72013, XrefRangeEnd = 72056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateLODs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildingLODMaker.NativeMethodInfoPtr_CreateLODs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000755C0 File Offset: 0x000737C0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildingLODMaker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildingLODMaker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildingLODMaker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002D4C File Offset: 0x00000F4C
		public BuildingLODMaker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000182 RID: 386 RVA: 0x000755FC File Offset: 0x000737FC
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00002D55 File Offset: 0x00000F55
		public unsafe Il2CppReferenceArray<BuildingLODMaker.LODGroupData> LODGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingLODMaker.NativeFieldInfoPtr_LODGroups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BuildingLODMaker.LODGroupData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingLODMaker.NativeFieldInfoPtr_LODGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000184 RID: 388 RVA: 0x0007562C File Offset: 0x0007382C
		// (set) Token: 0x06000185 RID: 389 RVA: 0x00002D74 File Offset: 0x00000F74
		public unsafe LODGroup LodGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingLODMaker.NativeFieldInfoPtr_LodGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LODGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingLODMaker.NativeFieldInfoPtr_LodGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeFieldInfoPtr_LODGroups;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeFieldInfoPtr_LodGroup;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_CreateLODs_Public_Void_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007A7 RID: 1959
		[Serializable]
		public class LODGroupData : Il2CppSystem.Object
		{
			// Token: 0x0600B92D RID: 47405 RVA: 0x002DFC60 File Offset: 0x002DDE60
			// Note: this type is marked as 'beforefieldinit'.
			static LODGroupData()
			{
				Il2CppClassPointerStore<BuildingLODMaker.LODGroupData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildingLODMaker>.NativeClassPtr, "LODGroupData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildingLODMaker.LODGroupData>.NativeClassPtr);
				BuildingLODMaker.LODGroupData.NativeFieldInfoPtr_ObjectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingLODMaker.LODGroupData>.NativeClassPtr, "ObjectName");
				BuildingLODMaker.LODGroupData.NativeFieldInfoPtr_LODObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingLODMaker.LODGroupData>.NativeClassPtr, "LODObject");
				BuildingLODMaker.LODGroupData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingLODMaker.LODGroupData>.NativeClassPtr, 100663424);
			}

			// Token: 0x0600B92E RID: 47406 RVA: 0x002DFCC8 File Offset: 0x002DDEC8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LODGroupData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildingLODMaker.LODGroupData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildingLODMaker.LODGroupData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B92F RID: 47407 RVA: 0x0005A88A File Offset: 0x00058A8A
			public LODGroupData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003924 RID: 14628
			// (get) Token: 0x0600B930 RID: 47408 RVA: 0x002DFD04 File Offset: 0x002DDF04
			// (set) Token: 0x0600B931 RID: 47409 RVA: 0x0005A893 File Offset: 0x00058A93
			public unsafe string ObjectName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingLODMaker.LODGroupData.NativeFieldInfoPtr_ObjectName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingLODMaker.LODGroupData.NativeFieldInfoPtr_ObjectName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003925 RID: 14629
			// (get) Token: 0x0600B932 RID: 47410 RVA: 0x002DFD2C File Offset: 0x002DDF2C
			// (set) Token: 0x0600B933 RID: 47411 RVA: 0x0005A8B2 File Offset: 0x00058AB2
			public unsafe GameObject LODObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingLODMaker.LODGroupData.NativeFieldInfoPtr_LODObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildingLODMaker.LODGroupData.NativeFieldInfoPtr_LODObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007CF6 RID: 31990
			private static readonly IntPtr NativeFieldInfoPtr_ObjectName;

			// Token: 0x04007CF7 RID: 31991
			private static readonly IntPtr NativeFieldInfoPtr_LODObject;

			// Token: 0x04007CF8 RID: 31992
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
