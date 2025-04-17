using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000594 RID: 1428
	[Serializable]
	public class LiquidMethDefinition : QualityItemDefinition
	{
		// Token: 0x06007DA5 RID: 32165 RVA: 0x0021A5B4 File Offset: 0x002187B4
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidMethDefinition()
		{
			Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "LiquidMethDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr);
			LiquidMethDefinition.NativeFieldInfoPtr_StaticLiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr, "StaticLiquidColor");
			LiquidMethDefinition.NativeFieldInfoPtr_LiquidVolumeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr, "LiquidVolumeColor");
			LiquidMethDefinition.NativeFieldInfoPtr_PourParticlesColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr, "PourParticlesColor");
			LiquidMethDefinition.NativeFieldInfoPtr_CookableLiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr, "CookableLiquidColor");
			LiquidMethDefinition.NativeFieldInfoPtr_CookableSolidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr, "CookableSolidColor");
			LiquidMethDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr, 100679012);
		}

		// Token: 0x06007DA6 RID: 32166 RVA: 0x0021A65C File Offset: 0x0021885C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238049, XrefRangeEnd = 238050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidMethDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidMethDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DA7 RID: 32167 RVA: 0x0003BBAE File Offset: 0x00039DAE
		public LiquidMethDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700260B RID: 9739
		// (get) Token: 0x06007DA8 RID: 32168 RVA: 0x0021A698 File Offset: 0x00218898
		// (set) Token: 0x06007DA9 RID: 32169 RVA: 0x0003BBB7 File Offset: 0x00039DB7
		public unsafe Color StaticLiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_StaticLiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_StaticLiquidColor)) = value;
			}
		}

		// Token: 0x1700260C RID: 9740
		// (get) Token: 0x06007DAA RID: 32170 RVA: 0x0021A6C0 File Offset: 0x002188C0
		// (set) Token: 0x06007DAB RID: 32171 RVA: 0x0003BBD2 File Offset: 0x00039DD2
		public unsafe Color LiquidVolumeColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_LiquidVolumeColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_LiquidVolumeColor)) = value;
			}
		}

		// Token: 0x1700260D RID: 9741
		// (get) Token: 0x06007DAC RID: 32172 RVA: 0x0021A6E8 File Offset: 0x002188E8
		// (set) Token: 0x06007DAD RID: 32173 RVA: 0x0003BBED File Offset: 0x00039DED
		public unsafe Color PourParticlesColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_PourParticlesColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_PourParticlesColor)) = value;
			}
		}

		// Token: 0x1700260E RID: 9742
		// (get) Token: 0x06007DAE RID: 32174 RVA: 0x0021A710 File Offset: 0x00218910
		// (set) Token: 0x06007DAF RID: 32175 RVA: 0x0003BC08 File Offset: 0x00039E08
		public unsafe Color CookableLiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_CookableLiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_CookableLiquidColor)) = value;
			}
		}

		// Token: 0x1700260F RID: 9743
		// (get) Token: 0x06007DB0 RID: 32176 RVA: 0x0021A738 File Offset: 0x00218938
		// (set) Token: 0x06007DB1 RID: 32177 RVA: 0x0003BC23 File Offset: 0x00039E23
		public unsafe Color CookableSolidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_CookableSolidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_CookableSolidColor)) = value;
			}
		}

		// Token: 0x04005575 RID: 21877
		private static readonly IntPtr NativeFieldInfoPtr_StaticLiquidColor;

		// Token: 0x04005576 RID: 21878
		private static readonly IntPtr NativeFieldInfoPtr_LiquidVolumeColor;

		// Token: 0x04005577 RID: 21879
		private static readonly IntPtr NativeFieldInfoPtr_PourParticlesColor;

		// Token: 0x04005578 RID: 21880
		private static readonly IntPtr NativeFieldInfoPtr_CookableLiquidColor;

		// Token: 0x04005579 RID: 21881
		private static readonly IntPtr NativeFieldInfoPtr_CookableSolidColor;

		// Token: 0x0400557A RID: 21882
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
