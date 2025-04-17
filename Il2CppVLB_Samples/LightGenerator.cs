using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppVLB_Samples
{
	// Token: 0x020000BE RID: 190
	public class LightGenerator : MonoBehaviour
	{
		// Token: 0x06000E23 RID: 3619 RVA: 0x0009DF7C File Offset: 0x0009C17C
		// Note: this type is marked as 'beforefieldinit'.
		static LightGenerator()
		{
			Il2CppClassPointerStore<LightGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB_Samples", "LightGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr);
			LightGenerator.NativeFieldInfoPtr_CountX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr, "CountX");
			LightGenerator.NativeFieldInfoPtr_CountY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr, "CountY");
			LightGenerator.NativeFieldInfoPtr_OffsetUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr, "OffsetUnits");
			LightGenerator.NativeFieldInfoPtr_PositionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr, "PositionY");
			LightGenerator.NativeFieldInfoPtr_NoiseEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr, "NoiseEnabled");
			LightGenerator.NativeFieldInfoPtr_AddLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr, "AddLight");
			LightGenerator.NativeMethodInfoPtr_Generate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr, 100665032);
			LightGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr, 100665033);
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x0009E04C File Offset: 0x0009C24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85589, XrefRangeEnd = 85677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Generate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightGenerator.NativeMethodInfoPtr_Generate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x0009E080 File Offset: 0x0009C280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85677, XrefRangeEnd = 85678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x00008D10 File Offset: 0x00006F10
		public LightGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x0009E0BC File Offset: 0x0009C2BC
		// (set) Token: 0x06000E28 RID: 3624 RVA: 0x00008D19 File Offset: 0x00006F19
		public unsafe int CountX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_CountX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_CountX)) = value;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x0009E0E4 File Offset: 0x0009C2E4
		// (set) Token: 0x06000E2A RID: 3626 RVA: 0x00008D34 File Offset: 0x00006F34
		public unsafe int CountY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_CountY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_CountY)) = value;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x0009E10C File Offset: 0x0009C30C
		// (set) Token: 0x06000E2C RID: 3628 RVA: 0x00008D4F File Offset: 0x00006F4F
		public unsafe float OffsetUnits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_OffsetUnits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_OffsetUnits)) = value;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x0009E134 File Offset: 0x0009C334
		// (set) Token: 0x06000E2E RID: 3630 RVA: 0x00008D6A File Offset: 0x00006F6A
		public unsafe float PositionY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_PositionY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_PositionY)) = value;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x0009E15C File Offset: 0x0009C35C
		// (set) Token: 0x06000E30 RID: 3632 RVA: 0x00008D85 File Offset: 0x00006F85
		public unsafe bool NoiseEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_NoiseEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_NoiseEnabled)) = value;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000E31 RID: 3633 RVA: 0x0009E184 File Offset: 0x0009C384
		// (set) Token: 0x06000E32 RID: 3634 RVA: 0x00008DA0 File Offset: 0x00006FA0
		public unsafe bool AddLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_AddLight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_AddLight)) = value;
			}
		}

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeFieldInfoPtr_CountX;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeFieldInfoPtr_CountY;

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeFieldInfoPtr_OffsetUnits;

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeFieldInfoPtr_PositionY;

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeFieldInfoPtr_NoiseEnabled;

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeFieldInfoPtr_AddLight;

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_Void_0;

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
