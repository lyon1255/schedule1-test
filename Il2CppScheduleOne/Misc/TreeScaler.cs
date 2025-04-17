using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x0200076D RID: 1901
	public class TreeScaler : MonoBehaviour
	{
		// Token: 0x0600B487 RID: 46215 RVA: 0x002CF13C File Offset: 0x002CD33C
		// Note: this type is marked as 'beforefieldinit'.
		static TreeScaler()
		{
			Il2CppClassPointerStore<TreeScaler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "TreeScaler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr);
			TreeScaler.NativeFieldInfoPtr_branchMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, "branchMeshes");
			TreeScaler.NativeFieldInfoPtr_minScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, "minScale");
			TreeScaler.NativeFieldInfoPtr_maxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, "maxScale");
			TreeScaler.NativeFieldInfoPtr_minScaleDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, "minScaleDistance");
			TreeScaler.NativeFieldInfoPtr_maxScaleDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, "maxScaleDistance");
			TreeScaler.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, 100685515);
			TreeScaler.NativeMethodInfoPtr_UpdateScale_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, 100685516);
			TreeScaler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, 100685517);
		}

		// Token: 0x0600B488 RID: 46216 RVA: 0x002CF20C File Offset: 0x002CD40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309288, XrefRangeEnd = 309306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TreeScaler.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B489 RID: 46217 RVA: 0x002CF248 File Offset: 0x002CD448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309306, XrefRangeEnd = 309335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeScaler.NativeMethodInfoPtr_UpdateScale_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B48A RID: 46218 RVA: 0x002CF27C File Offset: 0x002CD47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309335, XrefRangeEnd = 309343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TreeScaler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeScaler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B48B RID: 46219 RVA: 0x000588C8 File Offset: 0x00056AC8
		public TreeScaler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037F7 RID: 14327
		// (get) Token: 0x0600B48C RID: 46220 RVA: 0x002CF2B8 File Offset: 0x002CD4B8
		// (set) Token: 0x0600B48D RID: 46221 RVA: 0x000588D1 File Offset: 0x00056AD1
		public unsafe List<Transform> branchMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_branchMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_branchMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037F8 RID: 14328
		// (get) Token: 0x0600B48E RID: 46222 RVA: 0x002CF2E8 File Offset: 0x002CD4E8
		// (set) Token: 0x0600B48F RID: 46223 RVA: 0x000588F0 File Offset: 0x00056AF0
		public unsafe float minScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_minScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_minScale)) = value;
			}
		}

		// Token: 0x170037F9 RID: 14329
		// (get) Token: 0x0600B490 RID: 46224 RVA: 0x002CF310 File Offset: 0x002CD510
		// (set) Token: 0x0600B491 RID: 46225 RVA: 0x0005890B File Offset: 0x00056B0B
		public unsafe float maxScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_maxScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_maxScale)) = value;
			}
		}

		// Token: 0x170037FA RID: 14330
		// (get) Token: 0x0600B492 RID: 46226 RVA: 0x002CF338 File Offset: 0x002CD538
		// (set) Token: 0x0600B493 RID: 46227 RVA: 0x00058926 File Offset: 0x00056B26
		public unsafe float minScaleDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_minScaleDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_minScaleDistance)) = value;
			}
		}

		// Token: 0x170037FB RID: 14331
		// (get) Token: 0x0600B494 RID: 46228 RVA: 0x002CF360 File Offset: 0x002CD560
		// (set) Token: 0x0600B495 RID: 46229 RVA: 0x00058941 File Offset: 0x00056B41
		public unsafe float maxScaleDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_maxScaleDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_maxScaleDistance)) = value;
			}
		}

		// Token: 0x040079B2 RID: 31154
		private static readonly IntPtr NativeFieldInfoPtr_branchMeshes;

		// Token: 0x040079B3 RID: 31155
		private static readonly IntPtr NativeFieldInfoPtr_minScale;

		// Token: 0x040079B4 RID: 31156
		private static readonly IntPtr NativeFieldInfoPtr_maxScale;

		// Token: 0x040079B5 RID: 31157
		private static readonly IntPtr NativeFieldInfoPtr_minScaleDistance;

		// Token: 0x040079B6 RID: 31158
		private static readonly IntPtr NativeFieldInfoPtr_maxScaleDistance;

		// Token: 0x040079B7 RID: 31159
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040079B8 RID: 31160
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScale_Private_Void_0;

		// Token: 0x040079B9 RID: 31161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
