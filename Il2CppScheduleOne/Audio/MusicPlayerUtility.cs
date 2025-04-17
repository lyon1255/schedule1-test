using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004D5 RID: 1237
	public class MusicPlayerUtility : MonoBehaviour
	{
		// Token: 0x06006C39 RID: 27705 RVA: 0x001E0C08 File Offset: 0x001DEE08
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerUtility()
		{
			Il2CppClassPointerStore<MusicPlayerUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "MusicPlayerUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerUtility>.NativeClassPtr);
			MusicPlayerUtility.NativeMethodInfoPtr_PlayTrack_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerUtility>.NativeClassPtr, 100676979);
			MusicPlayerUtility.NativeMethodInfoPtr_StopTracks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerUtility>.NativeClassPtr, 100676980);
			MusicPlayerUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerUtility>.NativeClassPtr, 100676981);
		}

		// Token: 0x06006C3A RID: 27706 RVA: 0x001E0C74 File Offset: 0x001DEE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216760, XrefRangeEnd = 216784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayTrack(string trackName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trackName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerUtility.NativeMethodInfoPtr_PlayTrack_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C3B RID: 27707 RVA: 0x001E0CB8 File Offset: 0x001DEEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216784, XrefRangeEnd = 216790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopTracks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerUtility.NativeMethodInfoPtr_StopTracks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C3C RID: 27708 RVA: 0x001E0CEC File Offset: 0x001DEEEC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicPlayerUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicPlayerUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C3D RID: 27709 RVA: 0x000333B6 File Offset: 0x000315B6
		public MusicPlayerUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004A00 RID: 18944
		private static readonly IntPtr NativeMethodInfoPtr_PlayTrack_Public_Void_String_0;

		// Token: 0x04004A01 RID: 18945
		private static readonly IntPtr NativeMethodInfoPtr_StopTracks_Public_Void_0;

		// Token: 0x04004A02 RID: 18946
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
