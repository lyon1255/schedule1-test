using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Skating
{
	// Token: 0x020001A7 RID: 423
	public class SkateboardAudio : MonoBehaviour
	{
		// Token: 0x060023AF RID: 9135 RVA: 0x000DF5F8 File Offset: 0x000DD7F8
		// Note: this type is marked as 'beforefieldinit'.
		static SkateboardAudio()
		{
			Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Skating", "SkateboardAudio");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr);
			SkateboardAudio.NativeFieldInfoPtr_Board = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, "Board");
			SkateboardAudio.NativeFieldInfoPtr_JumpAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, "JumpAudio");
			SkateboardAudio.NativeFieldInfoPtr_LandAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, "LandAudio");
			SkateboardAudio.NativeFieldInfoPtr_RollingAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, "RollingAudio");
			SkateboardAudio.NativeFieldInfoPtr_WindAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, "WindAudio");
			SkateboardAudio.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, 100667269);
			SkateboardAudio.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, 100667270);
			SkateboardAudio.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, 100667271);
			SkateboardAudio.NativeMethodInfoPtr_PlayJump_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, 100667272);
			SkateboardAudio.NativeMethodInfoPtr_PlayLand_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, 100667273);
			SkateboardAudio.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, 100667274);
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x000DF704 File Offset: 0x000DD904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112589, XrefRangeEnd = 112606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAudio.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x000DF738 File Offset: 0x000DD938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112606, XrefRangeEnd = 112608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAudio.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x000DF76C File Offset: 0x000DD96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112608, XrefRangeEnd = 112614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAudio.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x000DF7A0 File Offset: 0x000DD9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112614, XrefRangeEnd = 112616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayJump(float force)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAudio.NativeMethodInfoPtr_PlayJump_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x000DF7E0 File Offset: 0x000DD9E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 112617, RefRangeEnd = 112621, XrefRangeStart = 112616, XrefRangeEnd = 112617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayLand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAudio.NativeMethodInfoPtr_PlayLand_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x000DF814 File Offset: 0x000DDA14
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkateboardAudio() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAudio.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x000140F1 File Offset: 0x000122F1
		public SkateboardAudio(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x060023B7 RID: 9143 RVA: 0x000DF850 File Offset: 0x000DDA50
		// (set) Token: 0x060023B8 RID: 9144 RVA: 0x000140FA File Offset: 0x000122FA
		public unsafe Skateboard Board
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_Board);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_Board), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x060023B9 RID: 9145 RVA: 0x000DF880 File Offset: 0x000DDA80
		// (set) Token: 0x060023BA RID: 9146 RVA: 0x00014119 File Offset: 0x00012319
		public unsafe AudioSourceController JumpAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_JumpAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_JumpAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x060023BB RID: 9147 RVA: 0x000DF8B0 File Offset: 0x000DDAB0
		// (set) Token: 0x060023BC RID: 9148 RVA: 0x00014138 File Offset: 0x00012338
		public unsafe AudioSourceController LandAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_LandAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_LandAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x060023BD RID: 9149 RVA: 0x000DF8E0 File Offset: 0x000DDAE0
		// (set) Token: 0x060023BE RID: 9150 RVA: 0x00014157 File Offset: 0x00012357
		public unsafe AudioSourceController RollingAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_RollingAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_RollingAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x060023BF RID: 9151 RVA: 0x000DF910 File Offset: 0x000DDB10
		// (set) Token: 0x060023C0 RID: 9152 RVA: 0x00014176 File Offset: 0x00012376
		public unsafe AudioSourceController WindAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_WindAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_WindAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017AB RID: 6059
		private static readonly IntPtr NativeFieldInfoPtr_Board;

		// Token: 0x040017AC RID: 6060
		private static readonly IntPtr NativeFieldInfoPtr_JumpAudio;

		// Token: 0x040017AD RID: 6061
		private static readonly IntPtr NativeFieldInfoPtr_LandAudio;

		// Token: 0x040017AE RID: 6062
		private static readonly IntPtr NativeFieldInfoPtr_RollingAudio;

		// Token: 0x040017AF RID: 6063
		private static readonly IntPtr NativeFieldInfoPtr_WindAudio;

		// Token: 0x040017B0 RID: 6064
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040017B1 RID: 6065
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040017B2 RID: 6066
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040017B3 RID: 6067
		private static readonly IntPtr NativeMethodInfoPtr_PlayJump_Public_Void_Single_0;

		// Token: 0x040017B4 RID: 6068
		private static readonly IntPtr NativeMethodInfoPtr_PlayLand_Public_Void_0;

		// Token: 0x040017B5 RID: 6069
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
