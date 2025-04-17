using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.StationFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000595 RID: 1429
	public class LiquidMethVisuals : MonoBehaviour
	{
		// Token: 0x06007DB2 RID: 32178 RVA: 0x0021A760 File Offset: 0x00218960
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidMethVisuals()
		{
			Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "LiquidMethVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr);
			LiquidMethVisuals.NativeFieldInfoPtr_StaticLiquidMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr, "StaticLiquidMesh");
			LiquidMethVisuals.NativeFieldInfoPtr_LiquidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr, "LiquidContainer");
			LiquidMethVisuals.NativeFieldInfoPtr_PourParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr, "PourParticles");
			LiquidMethVisuals.NativeMethodInfoPtr_Setup_Public_Void_LiquidMethDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr, 100679013);
			LiquidMethVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr, 100679014);
		}

		// Token: 0x06007DB3 RID: 32179 RVA: 0x0021A7F4 File Offset: 0x002189F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 238069, RefRangeEnd = 238072, XrefRangeStart = 238050, XrefRangeEnd = 238069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(LiquidMethDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidMethVisuals.NativeMethodInfoPtr_Setup_Public_Void_LiquidMethDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DB4 RID: 32180 RVA: 0x0021A838 File Offset: 0x00218A38
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidMethVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidMethVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DB5 RID: 32181 RVA: 0x0003BC3E File Offset: 0x00039E3E
		public LiquidMethVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002610 RID: 9744
		// (get) Token: 0x06007DB6 RID: 32182 RVA: 0x0021A874 File Offset: 0x00218A74
		// (set) Token: 0x06007DB7 RID: 32183 RVA: 0x0003BC47 File Offset: 0x00039E47
		public unsafe MeshRenderer StaticLiquidMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethVisuals.NativeFieldInfoPtr_StaticLiquidMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethVisuals.NativeFieldInfoPtr_StaticLiquidMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002611 RID: 9745
		// (get) Token: 0x06007DB8 RID: 32184 RVA: 0x0021A8A4 File Offset: 0x00218AA4
		// (set) Token: 0x06007DB9 RID: 32185 RVA: 0x0003BC66 File Offset: 0x00039E66
		public unsafe LiquidContainer LiquidContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethVisuals.NativeFieldInfoPtr_LiquidContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethVisuals.NativeFieldInfoPtr_LiquidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002612 RID: 9746
		// (get) Token: 0x06007DBA RID: 32186 RVA: 0x0021A8D4 File Offset: 0x00218AD4
		// (set) Token: 0x06007DBB RID: 32187 RVA: 0x0003BC85 File Offset: 0x00039E85
		public unsafe ParticleSystem PourParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethVisuals.NativeFieldInfoPtr_PourParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethVisuals.NativeFieldInfoPtr_PourParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400557B RID: 21883
		private static readonly IntPtr NativeFieldInfoPtr_StaticLiquidMesh;

		// Token: 0x0400557C RID: 21884
		private static readonly IntPtr NativeFieldInfoPtr_LiquidContainer;

		// Token: 0x0400557D RID: 21885
		private static readonly IntPtr NativeFieldInfoPtr_PourParticles;

		// Token: 0x0400557E RID: 21886
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_LiquidMethDefinition_0;

		// Token: 0x0400557F RID: 21887
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
