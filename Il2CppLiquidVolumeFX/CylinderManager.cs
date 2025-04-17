using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x020000CC RID: 204
	public class CylinderManager : MonoBehaviour
	{
		// Token: 0x06000F1A RID: 3866 RVA: 0x000A039C File Offset: 0x0009E59C
		// Note: this type is marked as 'beforefieldinit'.
		static CylinderManager()
		{
			Il2CppClassPointerStore<CylinderManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "CylinderManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CylinderManager>.NativeClassPtr);
			CylinderManager.NativeFieldInfoPtr_startingDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CylinderManager>.NativeClassPtr, "startingDelay");
			CylinderManager.NativeFieldInfoPtr_numCylinders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CylinderManager>.NativeClassPtr, "numCylinders");
			CylinderManager.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CylinderManager>.NativeClassPtr, "scale");
			CylinderManager.NativeFieldInfoPtr_heightMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CylinderManager>.NativeClassPtr, "heightMultiplier");
			CylinderManager.NativeFieldInfoPtr_circleRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CylinderManager>.NativeClassPtr, "circleRadius");
			CylinderManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylinderManager>.NativeClassPtr, 100665079);
			CylinderManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CylinderManager>.NativeClassPtr, 100665080);
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x000A0458 File Offset: 0x0009E658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86109, XrefRangeEnd = 86178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylinderManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x000A048C File Offset: 0x0009E68C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86178, XrefRangeEnd = 86179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CylinderManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CylinderManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CylinderManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x0000972C File Offset: 0x0000792C
		public CylinderManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000F1E RID: 3870 RVA: 0x000A04C8 File Offset: 0x0009E6C8
		// (set) Token: 0x06000F1F RID: 3871 RVA: 0x00009735 File Offset: 0x00007935
		public unsafe float startingDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CylinderManager.NativeFieldInfoPtr_startingDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CylinderManager.NativeFieldInfoPtr_startingDelay)) = value;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x000A04F0 File Offset: 0x0009E6F0
		// (set) Token: 0x06000F21 RID: 3873 RVA: 0x00009750 File Offset: 0x00007950
		public unsafe int numCylinders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CylinderManager.NativeFieldInfoPtr_numCylinders);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CylinderManager.NativeFieldInfoPtr_numCylinders)) = value;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x000A0518 File Offset: 0x0009E718
		// (set) Token: 0x06000F23 RID: 3875 RVA: 0x0000976B File Offset: 0x0000796B
		public unsafe float scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CylinderManager.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CylinderManager.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000F24 RID: 3876 RVA: 0x000A0540 File Offset: 0x0009E740
		// (set) Token: 0x06000F25 RID: 3877 RVA: 0x00009786 File Offset: 0x00007986
		public unsafe float heightMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CylinderManager.NativeFieldInfoPtr_heightMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CylinderManager.NativeFieldInfoPtr_heightMultiplier)) = value;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000F26 RID: 3878 RVA: 0x000A0568 File Offset: 0x0009E768
		// (set) Token: 0x06000F27 RID: 3879 RVA: 0x000097A1 File Offset: 0x000079A1
		public unsafe float circleRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CylinderManager.NativeFieldInfoPtr_circleRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CylinderManager.NativeFieldInfoPtr_circleRadius)) = value;
			}
		}

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeFieldInfoPtr_startingDelay;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeFieldInfoPtr_numCylinders;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeFieldInfoPtr_heightMultiplier;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeFieldInfoPtr_circleRadius;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
