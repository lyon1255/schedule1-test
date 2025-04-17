using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004C8 RID: 1224
	public class AmbientOneShot : MonoBehaviour
	{
		// Token: 0x06006B13 RID: 27411 RVA: 0x001DD70C File Offset: 0x001DB90C
		// Note: this type is marked as 'beforefieldinit'.
		static AmbientOneShot()
		{
			Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AmbientOneShot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr);
			AmbientOneShot.NativeFieldInfoPtr_Audio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "Audio");
			AmbientOneShot.NativeFieldInfoPtr_Volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "Volume");
			AmbientOneShot.NativeFieldInfoPtr_ChancePerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "ChancePerHour");
			AmbientOneShot.NativeFieldInfoPtr_CooldownTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "CooldownTime");
			AmbientOneShot.NativeFieldInfoPtr_PlayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "PlayTime");
			AmbientOneShot.NativeFieldInfoPtr_MinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "MinDistance");
			AmbientOneShot.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "MaxDistance");
			AmbientOneShot.NativeFieldInfoPtr_timeSinceLastPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "timeSinceLastPlay");
			AmbientOneShot.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, 100676859);
			AmbientOneShot.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, 100676860);
			AmbientOneShot.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, 100676861);
			AmbientOneShot.NativeMethodInfoPtr_Play_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, 100676862);
			AmbientOneShot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, 100676863);
		}

		// Token: 0x06006B14 RID: 27412 RVA: 0x001DD840 File Offset: 0x001DBA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215453, XrefRangeEnd = 215471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOneShot.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B15 RID: 27413 RVA: 0x001DD874 File Offset: 0x001DBA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215471, XrefRangeEnd = 215479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmosSelected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOneShot.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B16 RID: 27414 RVA: 0x001DD8A8 File Offset: 0x001DBAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215479, XrefRangeEnd = 215503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOneShot.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B17 RID: 27415 RVA: 0x001DD8DC File Offset: 0x001DBADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215503, XrefRangeEnd = 215505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOneShot.NativeMethodInfoPtr_Play_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B18 RID: 27416 RVA: 0x001DD910 File Offset: 0x001DBB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215505, XrefRangeEnd = 215506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbientOneShot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOneShot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B19 RID: 27417 RVA: 0x00032A28 File Offset: 0x00030C28
		public AmbientOneShot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002020 RID: 8224
		// (get) Token: 0x06006B1A RID: 27418 RVA: 0x001DD94C File Offset: 0x001DBB4C
		// (set) Token: 0x06006B1B RID: 27419 RVA: 0x00032A31 File Offset: 0x00030C31
		public unsafe AudioSourceController Audio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_Audio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_Audio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002021 RID: 8225
		// (get) Token: 0x06006B1C RID: 27420 RVA: 0x001DD97C File Offset: 0x001DBB7C
		// (set) Token: 0x06006B1D RID: 27421 RVA: 0x00032A50 File Offset: 0x00030C50
		public unsafe float Volume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_Volume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_Volume)) = value;
			}
		}

		// Token: 0x17002022 RID: 8226
		// (get) Token: 0x06006B1E RID: 27422 RVA: 0x001DD9A4 File Offset: 0x001DBBA4
		// (set) Token: 0x06006B1F RID: 27423 RVA: 0x00032A6B File Offset: 0x00030C6B
		public unsafe float ChancePerHour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_ChancePerHour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_ChancePerHour)) = value;
			}
		}

		// Token: 0x17002023 RID: 8227
		// (get) Token: 0x06006B20 RID: 27424 RVA: 0x001DD9CC File Offset: 0x001DBBCC
		// (set) Token: 0x06006B21 RID: 27425 RVA: 0x00032A86 File Offset: 0x00030C86
		public unsafe int CooldownTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_CooldownTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_CooldownTime)) = value;
			}
		}

		// Token: 0x17002024 RID: 8228
		// (get) Token: 0x06006B22 RID: 27426 RVA: 0x001DD9F4 File Offset: 0x001DBBF4
		// (set) Token: 0x06006B23 RID: 27427 RVA: 0x00032AA1 File Offset: 0x00030CA1
		public unsafe AmbientOneShot.EPlayTime PlayTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_PlayTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_PlayTime)) = value;
			}
		}

		// Token: 0x17002025 RID: 8229
		// (get) Token: 0x06006B24 RID: 27428 RVA: 0x001DDA1C File Offset: 0x001DBC1C
		// (set) Token: 0x06006B25 RID: 27429 RVA: 0x00032ABC File Offset: 0x00030CBC
		public unsafe float MinDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_MinDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_MinDistance)) = value;
			}
		}

		// Token: 0x17002026 RID: 8230
		// (get) Token: 0x06006B26 RID: 27430 RVA: 0x001DDA44 File Offset: 0x001DBC44
		// (set) Token: 0x06006B27 RID: 27431 RVA: 0x00032AD7 File Offset: 0x00030CD7
		public unsafe float MaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_MaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_MaxDistance)) = value;
			}
		}

		// Token: 0x17002027 RID: 8231
		// (get) Token: 0x06006B28 RID: 27432 RVA: 0x001DDA6C File Offset: 0x001DBC6C
		// (set) Token: 0x06006B29 RID: 27433 RVA: 0x00032AF2 File Offset: 0x00030CF2
		public unsafe int timeSinceLastPlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_timeSinceLastPlay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr_timeSinceLastPlay)) = value;
			}
		}

		// Token: 0x04004942 RID: 18754
		private static readonly IntPtr NativeFieldInfoPtr_Audio;

		// Token: 0x04004943 RID: 18755
		private static readonly IntPtr NativeFieldInfoPtr_Volume;

		// Token: 0x04004944 RID: 18756
		private static readonly IntPtr NativeFieldInfoPtr_ChancePerHour;

		// Token: 0x04004945 RID: 18757
		private static readonly IntPtr NativeFieldInfoPtr_CooldownTime;

		// Token: 0x04004946 RID: 18758
		private static readonly IntPtr NativeFieldInfoPtr_PlayTime;

		// Token: 0x04004947 RID: 18759
		private static readonly IntPtr NativeFieldInfoPtr_MinDistance;

		// Token: 0x04004948 RID: 18760
		private static readonly IntPtr NativeFieldInfoPtr_MaxDistance;

		// Token: 0x04004949 RID: 18761
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastPlay;

		// Token: 0x0400494A RID: 18762
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400494B RID: 18763
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;

		// Token: 0x0400494C RID: 18764
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x0400494D RID: 18765
		private static readonly IntPtr NativeMethodInfoPtr_Play_Private_Void_0;

		// Token: 0x0400494E RID: 18766
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A58 RID: 2648
		[OriginalName("Assembly-CSharp.dll", "", "EPlayTime")]
		public enum EPlayTime
		{
			// Token: 0x04008CA5 RID: 36005
			All,
			// Token: 0x04008CA6 RID: 36006
			Day,
			// Token: 0x04008CA7 RID: 36007
			Night
		}
	}
}
