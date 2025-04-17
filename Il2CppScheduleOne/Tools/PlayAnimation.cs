using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000545 RID: 1349
	public class PlayAnimation : MonoBehaviour
	{
		// Token: 0x06007760 RID: 30560 RVA: 0x00205F38 File Offset: 0x00204138
		// Note: this type is marked as 'beforefieldinit'.
		static PlayAnimation()
		{
			Il2CppClassPointerStore<PlayAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "PlayAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayAnimation>.NativeClassPtr);
			PlayAnimation.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAnimation>.NativeClassPtr, 100678336);
			PlayAnimation.NativeMethodInfoPtr_Play_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAnimation>.NativeClassPtr, 100678337);
			PlayAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAnimation>.NativeClassPtr, 100678338);
		}

		// Token: 0x06007761 RID: 30561 RVA: 0x00205FA4 File Offset: 0x002041A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231576, XrefRangeEnd = 231581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAnimation.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007762 RID: 30562 RVA: 0x00205FD8 File Offset: 0x002041D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231581, XrefRangeEnd = 231586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play(string animationName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(animationName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAnimation.NativeMethodInfoPtr_Play_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007763 RID: 30563 RVA: 0x0020601C File Offset: 0x0020421C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayAnimation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayAnimation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007764 RID: 30564 RVA: 0x00038864 File Offset: 0x00036A64
		public PlayAnimation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005179 RID: 20857
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

		// Token: 0x0400517A RID: 20858
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_String_0;

		// Token: 0x0400517B RID: 20859
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
