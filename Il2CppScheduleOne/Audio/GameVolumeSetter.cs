using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004D1 RID: 1233
	public class GameVolumeSetter : MonoBehaviour
	{
		// Token: 0x06006BFF RID: 27647 RVA: 0x001E016C File Offset: 0x001DE36C
		// Note: this type is marked as 'beforefieldinit'.
		static GameVolumeSetter()
		{
			Il2CppClassPointerStore<GameVolumeSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "GameVolumeSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameVolumeSetter>.NativeClassPtr);
			GameVolumeSetter.NativeFieldInfoPtr_VolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVolumeSetter>.NativeClassPtr, "VolumeMultiplier");
			GameVolumeSetter.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVolumeSetter>.NativeClassPtr, 100676954);
			GameVolumeSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVolumeSetter>.NativeClassPtr, 100676955);
		}

		// Token: 0x06006C00 RID: 27648 RVA: 0x001E01D8 File Offset: 0x001DE3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216487, XrefRangeEnd = 216493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameVolumeSetter.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C01 RID: 27649 RVA: 0x001E020C File Offset: 0x001DE40C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 74368, RefRangeEnd = 74372, XrefRangeStart = 74368, XrefRangeEnd = 74372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameVolumeSetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameVolumeSetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameVolumeSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C02 RID: 27650 RVA: 0x00033200 File Offset: 0x00031400
		public GameVolumeSetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002078 RID: 8312
		// (get) Token: 0x06006C03 RID: 27651 RVA: 0x001E0248 File Offset: 0x001DE448
		// (set) Token: 0x06006C04 RID: 27652 RVA: 0x00033209 File Offset: 0x00031409
		public unsafe float VolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameVolumeSetter.NativeFieldInfoPtr_VolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameVolumeSetter.NativeFieldInfoPtr_VolumeMultiplier)) = value;
			}
		}

		// Token: 0x040049DD RID: 18909
		private static readonly IntPtr NativeFieldInfoPtr_VolumeMultiplier;

		// Token: 0x040049DE RID: 18910
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040049DF RID: 18911
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
