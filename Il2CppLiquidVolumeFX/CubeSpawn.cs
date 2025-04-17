using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x020000C9 RID: 201
	public class CubeSpawn : MonoBehaviour
	{
		// Token: 0x06000EE4 RID: 3812 RVA: 0x0009FC04 File Offset: 0x0009DE04
		// Note: this type is marked as 'beforefieldinit'.
		static CubeSpawn()
		{
			Il2CppClassPointerStore<CubeSpawn>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "CubeSpawn");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CubeSpawn>.NativeClassPtr);
			CubeSpawn.NativeFieldInfoPtr_instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CubeSpawn>.NativeClassPtr, "instances");
			CubeSpawn.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CubeSpawn>.NativeClassPtr, "radius");
			CubeSpawn.NativeFieldInfoPtr_jitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CubeSpawn>.NativeClassPtr, "jitter");
			CubeSpawn.NativeFieldInfoPtr_expansion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CubeSpawn>.NativeClassPtr, "expansion");
			CubeSpawn.NativeFieldInfoPtr_laps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CubeSpawn>.NativeClassPtr, "laps");
			CubeSpawn.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubeSpawn>.NativeClassPtr, 100665071);
			CubeSpawn.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubeSpawn>.NativeClassPtr, 100665072);
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x0009FCC0 File Offset: 0x0009DEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86038, XrefRangeEnd = 86065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubeSpawn.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x0009FCF4 File Offset: 0x0009DEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86065, XrefRangeEnd = 86066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CubeSpawn() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubeSpawn>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CubeSpawn.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x000094F5 File Offset: 0x000076F5
		public CubeSpawn(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x0009FD30 File Offset: 0x0009DF30
		// (set) Token: 0x06000EE9 RID: 3817 RVA: 0x000094FE File Offset: 0x000076FE
		public unsafe int instances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CubeSpawn.NativeFieldInfoPtr_instances);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CubeSpawn.NativeFieldInfoPtr_instances)) = value;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x0009FD58 File Offset: 0x0009DF58
		// (set) Token: 0x06000EEB RID: 3819 RVA: 0x00009519 File Offset: 0x00007719
		public unsafe float radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CubeSpawn.NativeFieldInfoPtr_radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CubeSpawn.NativeFieldInfoPtr_radius)) = value;
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x0009FD80 File Offset: 0x0009DF80
		// (set) Token: 0x06000EED RID: 3821 RVA: 0x00009534 File Offset: 0x00007734
		public unsafe float jitter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CubeSpawn.NativeFieldInfoPtr_jitter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CubeSpawn.NativeFieldInfoPtr_jitter)) = value;
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000EEE RID: 3822 RVA: 0x0009FDA8 File Offset: 0x0009DFA8
		// (set) Token: 0x06000EEF RID: 3823 RVA: 0x0000954F File Offset: 0x0000774F
		public unsafe float expansion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CubeSpawn.NativeFieldInfoPtr_expansion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CubeSpawn.NativeFieldInfoPtr_expansion)) = value;
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000EF0 RID: 3824 RVA: 0x0009FDD0 File Offset: 0x0009DFD0
		// (set) Token: 0x06000EF1 RID: 3825 RVA: 0x0000956A File Offset: 0x0000776A
		public unsafe float laps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CubeSpawn.NativeFieldInfoPtr_laps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CubeSpawn.NativeFieldInfoPtr_laps)) = value;
			}
		}

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeFieldInfoPtr_instances;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeFieldInfoPtr_radius;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeFieldInfoPtr_jitter;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeFieldInfoPtr_expansion;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeFieldInfoPtr_laps;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
