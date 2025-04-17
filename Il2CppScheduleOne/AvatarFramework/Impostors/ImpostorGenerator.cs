using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Impostors
{
	// Token: 0x020005FC RID: 1532
	public class ImpostorGenerator : MonoBehaviour
	{
		// Token: 0x06008709 RID: 34569 RVA: 0x0023ABC8 File Offset: 0x00238DC8
		// Note: this type is marked as 'beforefieldinit'.
		static ImpostorGenerator()
		{
			Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Impostors", "ImpostorGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr);
			ImpostorGenerator.NativeFieldInfoPtr_ImpostorCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr, "ImpostorCamera");
			ImpostorGenerator.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr, "Avatar");
			ImpostorGenerator.NativeFieldInfoPtr_GenerationQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr, "GenerationQueue");
			ImpostorGenerator.NativeFieldInfoPtr_output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr, "output");
			ImpostorGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr, 100680159);
		}

		// Token: 0x0600870A RID: 34570 RVA: 0x0023AC5C File Offset: 0x00238E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251107, XrefRangeEnd = 251115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImpostorGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImpostorGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600870B RID: 34571 RVA: 0x000403CE File Offset: 0x0003E5CE
		public ImpostorGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700290A RID: 10506
		// (get) Token: 0x0600870C RID: 34572 RVA: 0x0023AC98 File Offset: 0x00238E98
		// (set) Token: 0x0600870D RID: 34573 RVA: 0x000403D7 File Offset: 0x0003E5D7
		public unsafe Camera ImpostorCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_ImpostorCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_ImpostorCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700290B RID: 10507
		// (get) Token: 0x0600870E RID: 34574 RVA: 0x0023ACC8 File Offset: 0x00238EC8
		// (set) Token: 0x0600870F RID: 34575 RVA: 0x000403F6 File Offset: 0x0003E5F6
		public unsafe Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700290C RID: 10508
		// (get) Token: 0x06008710 RID: 34576 RVA: 0x0023ACF8 File Offset: 0x00238EF8
		// (set) Token: 0x06008711 RID: 34577 RVA: 0x00040415 File Offset: 0x0003E615
		public unsafe List<AvatarSettings> GenerationQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_GenerationQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AvatarSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_GenerationQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700290D RID: 10509
		// (get) Token: 0x06008712 RID: 34578 RVA: 0x0023AD28 File Offset: 0x00238F28
		// (set) Token: 0x06008713 RID: 34579 RVA: 0x00040434 File Offset: 0x0003E634
		public unsafe Texture2D output
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_output);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_output), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005BE3 RID: 23523
		private static readonly IntPtr NativeFieldInfoPtr_ImpostorCamera;

		// Token: 0x04005BE4 RID: 23524
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04005BE5 RID: 23525
		private static readonly IntPtr NativeFieldInfoPtr_GenerationQueue;

		// Token: 0x04005BE6 RID: 23526
		private static readonly IntPtr NativeFieldInfoPtr_output;

		// Token: 0x04005BE7 RID: 23527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
