using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x0200058C RID: 1420
	public class LiquidLevelVisuals : MonoBehaviour
	{
		// Token: 0x06007D05 RID: 32005 RVA: 0x002188E4 File Offset: 0x00216AE4
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidLevelVisuals()
		{
			Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "LiquidLevelVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr);
			LiquidLevelVisuals.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr, "Container");
			LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr, "LiquidSurface");
			LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr, "LiquidSurface_Min");
			LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr, "LiquidSurface_Max");
			LiquidLevelVisuals.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr, 100678955);
			LiquidLevelVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr, 100678956);
		}

		// Token: 0x06007D06 RID: 32006 RVA: 0x0021898C File Offset: 0x00216B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237577, XrefRangeEnd = 237590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidLevelVisuals.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D07 RID: 32007 RVA: 0x002189C0 File Offset: 0x00216BC0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidLevelVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidLevelVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D08 RID: 32008 RVA: 0x0003B5D7 File Offset: 0x000397D7
		public LiquidLevelVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025D2 RID: 9682
		// (get) Token: 0x06007D09 RID: 32009 RVA: 0x002189FC File Offset: 0x00216BFC
		// (set) Token: 0x06007D0A RID: 32010 RVA: 0x0003B5E0 File Offset: 0x000397E0
		public unsafe LiquidContainer Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025D3 RID: 9683
		// (get) Token: 0x06007D0B RID: 32011 RVA: 0x00218A2C File Offset: 0x00216C2C
		// (set) Token: 0x06007D0C RID: 32012 RVA: 0x0003B5FF File Offset: 0x000397FF
		public unsafe Transform LiquidSurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025D4 RID: 9684
		// (get) Token: 0x06007D0D RID: 32013 RVA: 0x00218A5C File Offset: 0x00216C5C
		// (set) Token: 0x06007D0E RID: 32014 RVA: 0x0003B61E File Offset: 0x0003981E
		public unsafe Transform LiquidSurface_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface_Min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025D5 RID: 9685
		// (get) Token: 0x06007D0F RID: 32015 RVA: 0x00218A8C File Offset: 0x00216C8C
		// (set) Token: 0x06007D10 RID: 32016 RVA: 0x0003B63D File Offset: 0x0003983D
		public unsafe Transform LiquidSurface_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005516 RID: 21782
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005517 RID: 21783
		private static readonly IntPtr NativeFieldInfoPtr_LiquidSurface;

		// Token: 0x04005518 RID: 21784
		private static readonly IntPtr NativeFieldInfoPtr_LiquidSurface_Min;

		// Token: 0x04005519 RID: 21785
		private static readonly IntPtr NativeFieldInfoPtr_LiquidSurface_Max;

		// Token: 0x0400551A RID: 21786
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400551B RID: 21787
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
